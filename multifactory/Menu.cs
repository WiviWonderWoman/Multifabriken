using System;
using System.Collections.Generic;

namespace multifactory
{
/*=====================================CLASS==================================================
class Menu inherits from Order
handles menus, output and user input in sub-menu
==============================================================================================*/
    abstract class Menu : Order
    {
        /*-----------------METHOD------------------------------------------
         calls method that returns list order
         presents the Mainmenu
        -------------------------------------------------------------------*/
        public static void ShowMainMenu()
        {
            //List for orded products
            var order = CreateOrder();

            Console.WriteLine("HUVUDMENY");
            Console.WriteLine("[1] Beställa\n[2] Visa order\n[0] Avsluta");
        }

        /*-----------------METHOD--------------------------------------------------
         takes one argument, order list.
         keeps showing sub-menu until user choose to retur 
         switch statement with conditions based on user input 
            decides what kind of product - methodcall to product.orderProduct
            or return to Mainmenu
            catches incorrect entry, lets user try again
         orders products, add object to order
        ---------------------------------------------------------------------------*/
        public static void ShowSubMenu(List<Product> order)
        {
            bool sub = true;
            do
            {
                Console.WriteLine("PRODUKTMENY");
                Console.WriteLine("[B]il\n[G]odis\n[S]nöre\n[T]ofu\n[H]uvudmeny");

                var subIn = Console.ReadLine();
                var subInput = subIn.ToUpper();

                switch (subInput)
                {
                    case "B":
                        var car = Car.orderCar();
                        AddToOrder(order, car);
                        ShowConfirmation();
                        break;

                    case "G":
                        var sweets = Sweets.orderSweets();
                        AddToOrder(order, sweets);
                        ShowConfirmation();
                        break;

                    case "S":
                        var lace = Lace.orderLace();
                        AddToOrder(order, lace);
                        ShowConfirmation();
                        break;

                    case "T":
                        var tofu = Tofu.orderTofu();
                        AddToOrder(order, tofu);
                        ShowConfirmation();
                        break;

                    case "H":
                        Console.Clear();
                        sub = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Hoppsan, ogiltligt val. Försök igen!");
                        sub = true;
                        break;
                }
            } while (sub);
        }
        
        /*-----------------METHOD-------------------------------------------------------------------------
         shows order-confirmation, keeps the output visible until user choose to continue, back to Submeny
        --------------------------------------------------------------------------------------------------*/
        private static void ShowConfirmation()
        {
            Console.Clear();

            Console.WriteLine("Produkten är tillagd i din order. Välj [2] i huvudmenyn för detaljer.");

            Console.WriteLine("\nTryck på valfri knapp för att återgå till Produktmenyn.");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
