using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    class PromotionAorB
    {
        public int applyPromotionAorB(int skuQuantity, int promotionQuantity, int promotionValue, int skuItemPrice)
        {
            var priceA = 0;
            if (skuQuantity < promotionQuantity)
            {
                priceA = skuQuantity * skuItemPrice;
            }
            else if (skuQuantity == promotionQuantity)
            {
                priceA = promotionValue;
            }
            else
            {
                var remainingQuantity = skuQuantity % promotionQuantity;
                var noOfPromotionQuantity = skuQuantity / promotionQuantity;
                priceA += noOfPromotionQuantity * promotionValue + remainingQuantity * skuItemPrice;
            }
            return priceA;
        }
    }
}
