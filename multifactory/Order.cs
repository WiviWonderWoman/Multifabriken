using System.Collections.Generic;

namespace multifactory
{
/*=====================================CLASS==================================================
class Order, Parent class to Menu 
contains all the methods for generating, modifying and exposing orders
==============================================================================================*/
        abstract class Order 
    {
        /*-----------------METHOD----------------------------------
        creates the list order that keeps track of ordered products 
        -----------------------------------------------------------*/
        public static List<Product> CreateOrder()
        {
            List<Product> order =  new List<Product>();
            return order;
        }

        /*-----------------METHOD-----------------------------------------
        takes two argument and adds product to List 
        ------------------------------------------------------------------*/
        public static void AddToOrder(List<Product> order,Product product)
        {
            order.Add(product);
        }
        
        /*-----------------METHOD--------------------------
        iterates through the list and calls product method
        --------------------------------------------------*/
        public static void ShowOrder(List<Product> order)
        {
            foreach (Product product in order)
            {
                product.ShowProducts();
            }
        }
    }
}
