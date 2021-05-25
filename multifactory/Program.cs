using System;

namespace multifactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //List for orded products
            var order = Order.CreateOrder();

            // varibles to control iteration of the Mainmenu
            bool main = true;

            // Welcome and introductory message
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabriken!");
            Console.WriteLine("Vad kan vi stå till tjänst med?");

            // LOOP
            // displaying Mainmenu, conditions based on user input
            do
            {
                Menu.ShowMainMenu();
                var mainInput = Console.ReadLine();
                
                // ORDER PRODUCTS
                // methodcall to show submenu
                if (mainInput == "1")
                {
                    Console.Clear();
                    Menu.ShowSubMenu(order);
                }

                // SHOW ORDER
                // check if order is empty, iterate through order and call method to show order
                // keeps the output visible until user choose to continue back to Mainmeny
                else if (mainInput == "2")
                {
                    Console.Clear();

                    if (order.Count == 0)
                    {
                        Console.WriteLine("Din order är tom.");
                    }

                    else
                    {
                        Order.ShowOrder(order);
                    }

                    Console.WriteLine("\nTryck på valfri knapp för att återgå till Huvudmenyn.");
                    Console.ReadKey();
                    Console.Clear();
                }

                // EXIT
                // closing message
                else if (mainInput == "0")
                {
                    Console.Clear();
                    Console.WriteLine("Tack för besöket.\nVälkommen åter!");
                    return;
                }

                // ERROR
                // catches incorrect entry and lets the user try again
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hoppsan, ogiltligt val. Försök igen!\n");
                }

            } while (main);
        }
    }
}
