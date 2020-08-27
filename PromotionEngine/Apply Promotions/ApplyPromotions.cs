using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine.Apply_Promotions
{
    class ApplyPromotions : IApplyPromotions
    {
        public override int ApplyPromotionAndCalculateTotal(List<Order> skuOrders)
        {
            int finalPrice = 0;
            bool ispromotionCDApplied = false;
            foreach (var item in skuOrders)
            {
                if (item.skuItem == SKUItems.A)
                {
                    var promotionA = new PromotionAorB();
                    finalPrice += promotionA.applyPromotionAorB(item.quantity, (int)PromotionQuantity.A, (int)PromotionValue.A,
                    (int)SKUItems.A);
                }
                else if (item.skuItem == SKUItems.B)
                {
                    var promotionB = new PromotionAorB();
                    finalPrice += promotionB.applyPromotionAorB(item.quantity, (int)PromotionQuantity.B, (int)PromotionValue.B,
                    (int)SKUItems.B);
                }
                else if (item.skuItem == SKUItems.C)
                {
                    if (!ispromotionCDApplied)
                    {
                      var promotionC = new PromotionC();
                        finalPrice += promotionC.applyPromotionC(skuOrders, item.quantity);
                        ispromotionCDApplied = true;
                    }
                }

                else if (item.skuItem == SKUItems.D)
                {
                    if (!ispromotionCDApplied)
                    {
                        var promotionD = new PromotionD();
                        finalPrice += promotionD.applyPromotionD(skuOrders, item.quantity);
                        ispromotionCDApplied = true;
                    }
                }
            }
            return finalPrice;
        }
    }
}
