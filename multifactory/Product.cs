using System;

namespace multifactory
{
/*=====================================CLASS==================================================
class Product, Parent class to Car, Sweets, Lace and Tofu
an abstract class that provides its subclasses with two attributes and an abstract method
==============================================================================================*/
    
    abstract class Product
    {
        protected string trait;
        protected double amount;
        
    /*-----------------METHOD-----------------------
     abstract method, overriden in each subclass
    ------------------------------------------------*/
        public abstract void ShowProducts();
        
    }
}