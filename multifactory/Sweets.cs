using System;

namespace multifactory
{
/*=====================================CLASS==================================================
class Sweets inherits from Product, handels everything about sweets. 
==============================================================================================*/
    class Sweets : Product
    {
        /*-----------------METHOD-------------------------------
         constructor, takes two arguments (string and double)
        -------------------------------------------------------*/
        private Sweets(string traitToSet, double amountToSet)
        {
            trait = traitToSet;
            amount = amountToSet;
        }

        /*-----------------METHOD---------------------------------------------
         shows information about the product
        ----------------------------------------------------------------------*/
        public override void ShowProducts()
        {
            Console.WriteLine(amount+" st godisar med smak av "+trait+".");
        }

        /*-----------------METHOD---------------------------------------------------
         ask user for details about the product, generates and retruns a new object
        ----------------------------------------------------------------------------*/
        public static Sweets orderSweets()
        {
            Console.Clear();
            Console.WriteLine("GODIS");

            Console.WriteLine("Vilket smak önskas?");
            var flavour = Console.ReadLine();
            
            Console.WriteLine("Hur många?");
            int amount = ReadInt();

            Sweets sweets = new Sweets(flavour, amount);
            return sweets;
        }
        
        /*-----------------METHOD---------------------------------------------------
         checks if input is an integer, lets user try again
        ----------------------------------------------------------------------------*/
        private static int ReadInt()
        {
            int number;
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine("Du skrev inte in ett tal. Försök igen.");
            }
            return number;
        }
    }
}