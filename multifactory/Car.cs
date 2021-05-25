using System;

namespace multifactory
{
/*=====================================CLASS==================================================
class Car inherits from Product, handels everything about cars. 
==============================================================================================*/
    class Car : Product
    {
        private string color;
        private string regNumber;

        /*-----------------METHOD-----------------------------------------------
         constructor, takes three string arguments
        ------------------------------------------------------------------------*/
        private Car(string traitToSet, string colorToSet, string regNumberToSet)
        {
            trait = traitToSet;
            color = colorToSet;
            regNumber = regNumberToSet;
            amount = 1;
        }
        
        /*-----------------METHOD-------------------------------------------------------------------
         shows information about the product
        --------------------------------------------------------------------------------------------*/
        public override void ShowProducts()
        {
            Console.WriteLine(amount+" st "+color+" "+trait+" med registreringsnummer: "+regNumber);
        }
        
        /*-----------------METHOD---------------------------------------------------
         ask user for details about the product, generates and retruns a new object
        ----------------------------------------------------------------------------*/
        public static Car orderCar()
        {
            Console.Clear();
            Console.WriteLine("BIL");

            Console.WriteLine("Vilket märke skall bilen vara av?");
            var brand = Console.ReadLine();

            Console.WriteLine("Vad önskar Ni för färg?");
            var color = Console.ReadLine();
            
            Console.WriteLine("Ange önskat registreringsnummer:");
            var regNumber = Console.ReadLine();

            Car car = new Car(brand, color, regNumber);
            return car;
        }
    }
}
