using System;

namespace multifactory
{
/*=====================================CLASS==================================================
class Lace inherits from Product, handels everything about lace. 
==============================================================================================*/
    class Lace : Product
    {
        /*-----------------METHOD-------------------------------
         constructor, takes two arguments (string and double)
        -------------------------------------------------------*/
        public Lace(string traitToSet, double amountToSet)
        {
            trait = traitToSet;
            amount = amountToSet;
        }

        /*-----------------METHOD-------------------------------------------
         shows information about the product
        -------------------------------------------------------------------*/
        public override void ShowProducts()
        {
            Console.WriteLine(amount+" meter snöre i färgen "+trait+".");
        }

        /*-----------------METHOD---------------------------------------------------
         ask user for details about the product, generates and retruns a new object
        ----------------------------------------------------------------------------*/
        public static Lace orderLace()
        {
            Console.Clear();
            Console.WriteLine("SNÖRE");

            Console.WriteLine("Vilken färg vill Ni ha på snöret?");
            var color = Console.ReadLine();
            
            Console.WriteLine("Hur långt? Ange i meter:");
            double amount = ReadDouble();

            Lace lace = new Lace(color, amount);
            return lace;
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