using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Apply_Promotions
{
    public abstract class IApplyPromotions
    {
        public abstract int ApplyPromotionAndCalculateTotal(List<Order> skuOrders);

        public int TotalAfterAppliedPromotion(List<Order> skuOrders)
        {
            var finalPrice = ApplyPromotionAndCalculateTotal(skuOrders);

            //Some processing can be done here before returning final price

            return finalPrice;
        }

    }
}
