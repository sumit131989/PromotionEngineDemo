using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    class PromotionC
    {
        public int applyPromotionC(List<Order> skuOrders, int skuQuantity)
        {
            var promotionValue = (int)PromotionValue.CD;
            int skuItemPrice = 0;
            int remainingQuantity = 0;
            int priceC = 0;
            var orderD = skuOrders.SingleOrDefault(x => x.skuItem == SKUItems.D);
            if (orderD != null)
            {
                var skuItemDquantity = orderD.quantity;
                if (skuItemDquantity > skuQuantity)
                {
                    skuItemPrice = (int)SKUItems.D;
                    remainingQuantity = skuItemDquantity - skuQuantity;
                }
                else if (skuItemDquantity < skuQuantity)
                {
                    skuItemPrice = (int)SKUItems.C;
                    remainingQuantity = skuQuantity - skuItemDquantity;
                }
                else
                {
                    remainingQuantity = 0;
                }
                var noOfPromotionQuantity = (skuItemDquantity + skuQuantity) / 2;
                priceC = noOfPromotionQuantity * promotionValue + remainingQuantity * skuItemPrice;
            }
            else
            {
                skuItemPrice = (int)SKUItems.C;
                priceC = skuQuantity * skuItemPrice;
            }
            return priceC;
        }
    }
}
