using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    class PromotionD
    {
        public int applyPromotionD(List<Order> skuOrders, int skuQuantity)
        {
            var promotionValue = (int)PromotionValue.CD;
            int skuItemPrice = 0;
            int remainingQuantity = 0;
            int priceD = 0;
            var orderC = skuOrders.SingleOrDefault(x => x.skuItem == SKUItems.D);
            if (orderC != null)
            {
                var skuItemCquantity = orderC.quantity;
                if (skuItemCquantity > skuQuantity)
                {
                    skuItemPrice = (int)SKUItems.C;
                    remainingQuantity = skuItemCquantity - skuQuantity;
                }
                else if (skuItemCquantity < skuQuantity)
                {
                    skuItemPrice = (int)SKUItems.D;
                    remainingQuantity = skuQuantity - skuItemCquantity;
                }
                else
                {
                    remainingQuantity = 0;
                }
                var noOfPromotionQuantity = (skuItemCquantity + skuQuantity) / 2;
                priceD = noOfPromotionQuantity * promotionValue + remainingQuantity * skuItemPrice;
            }
            else
            {
                skuItemPrice = (int)SKUItems.C;
                priceD = skuQuantity * skuItemPrice;
            }
            return priceD;
        }
    }
}
