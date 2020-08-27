using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    class OrderHelper
    {
        private readonly SKUItems _skuItem;
        private readonly int _quantity;

        public OrderHelper(SKUItems skuItem, int quantity)
        {
            _skuItem = skuItem;
            _quantity = quantity;
        }
        public Order generateOrder()
        {
            return new Order
            {
                skuItem = _skuItem,
                quantity = _quantity
            };
        }
    }
}
