using PromotionEngine.Apply_Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.SKUItemsAndPromotionsApplicable;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Initialization"
            var lstOrders = new List<Order>();
            bool isValidInput = true;
            int quantity = 0;
            #endregion

            #region "Get user data for SKU A"
            Console.Write("Enter the Quantity for A: ");
            var userValue = Console.ReadLine().Trim();
            isValidInput = int.TryParse(userValue, out quantity);
            if (quantity > 0)
            {
                var skuItem = SKUItems.A;
                var orderHelper = new OrderHelper(skuItem, quantity);
                var order = orderHelper.generateOrder();
                lstOrders.Add(order);
            }
            #endregion

            #region "Get user data for SKU B"
            Console.Write("Enter the Quantity for B: ");
            userValue = Console.ReadLine().Trim();
            isValidInput = int.TryParse(userValue, out quantity);
            if (quantity > 0)
            {
                var skuItem = SKUItems.B;
                var orderHelper = new OrderHelper(skuItem, quantity);
                var order = orderHelper.generateOrder();
                lstOrders.Add(order);
            }
            #endregion

            #region "Get user data for SKU C"
            Console.Write("Enter the Quantity for C: ");
            userValue = Console.ReadLine().Trim();
            isValidInput = int.TryParse(userValue, out quantity);
            if (quantity > 0)
            {
                var skuItem = SKUItems.C;
                var orderHelper = new OrderHelper(skuItem, quantity);
                var order = orderHelper.generateOrder();
                lstOrders.Add(order);
            }
            #endregion

            #region "Get user data for SKU D"
            Console.Write("Enter the Quantity for D: ");
            userValue = Console.ReadLine().Trim();
            isValidInput = int.TryParse(userValue, out quantity);
            if (quantity > 0)
            {
                var skuItem = SKUItems.D;
                var orderHelper = new OrderHelper(skuItem, quantity);
                var order = orderHelper.generateOrder();
                lstOrders.Add(order);
            }
            #endregion

            #region "Apply promotion and Calculate"
            var shoppingCart = new ShoppingCart(new ApplyPromotions(), lstOrders);
            var finalPrice = shoppingCart.GetPriceAfterPromotionsApplied();
            Console.WriteLine("The total cost of all the items is: " + finalPrice);
            Console.ReadLine();
            #endregion
        }
    }
}
