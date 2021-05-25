using System;

namespace multifactory
{
/*=====================================CLASS==================================================
class Tofu inherits from Product, handels everything about tofu. 
==============================================================================================*/
     class Tofu : Product
    {
        /*-----------------METHOD-------------------------------
         constructor, takes two arguments (string and double)
        -------------------------------------------------------*/
        public Tofu(string traitToSet, double amountToSet)
        {
            trait = traitToSet;
            amount = amountToSet;
        }

        /*-----------------METHOD-------------------------------------------
         shows information about the product
        -------------------------------------------------------------------*/
        public override void ShowProducts()
        {
            Console.WriteLine(amount+" liter Tofu kryddad med "+trait+".");
        }

        /*-----------------METHOD---------------------------------------------------
         ask user for details about the product, generates and retruns a new object
        ----------------------------------------------------------------------------*/
        public static Tofu orderTofu()
        {
            Console.Clear();
            Console.WriteLine("TOFU");

            Console.WriteLine("Hur vill du ha kryddingen?");
            var seasoning = Console.ReadLine();
            
            Console.WriteLine("Hur mycket? Ange i liter:");
            double amount = ReadDouble();

            Tofu tofu = new Tofu(seasoning, amount);
            return tofu;
        }
        
        /*-----------------METHOD---------------------------------------------------
         checks if input is a decimal number, lets user try again
        ----------------------------------------------------------------------------*/
         private static double ReadDouble()
        {
            double number;
            while (double.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine("Du skrev inte in ett tal. Försök igen.");
            }
            return number;
        }
    }
}