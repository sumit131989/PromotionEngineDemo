using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    public class Order
    {
        public SKUItems skuItem { get; set; }
        public int quantity { get; set; }
    }
}
