using PromotionEngine.Apply_Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ShoppingCart
    {
        private IApplyPromotions _applyPromotions;
        private List<Order> _lstOrders;
        public ShoppingCart(IApplyPromotions applyPromotions, List<Order> lstOrders)
        {
            _applyPromotions = applyPromotions;
            _lstOrders = lstOrders;
        }

        public int GetPriceAfterPromotionsApplied()
        {
            return _applyPromotions.ApplyPromotionAndCalculateTotal(_lstOrders);
        }
    }
}
