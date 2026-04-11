using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourteenthtry
{
    abstract class FoodOrder: IDeliverable
    {
        public abstract void GetDeliveryTime();// Interface method implementation
        public abstract void CalculateTotalPrice();
        public virtual void GetInfo()
        { }


        private protected string Name { get; set; }
        private protected int Price { get; set; }
        private protected int Quantity { get; set; }
        private protected int Money { get; set; }
    }
    class PizzaOrder : FoodOrder
    {
        private protected string Size { get; set; }
        private protected int Siize { get; set; }
        public override void CalculateTotalPrice()
        {
            Money = Price * Quantity + Siize;
            Console.WriteLine("Вартiсть: " + Money);
        }
        public override void GetDeliveryTime() 
        {
            int time = 10*Quantity;
            if(Size == "Large")
                time += 10;
            else if(Size == "Medium")
                time += 5;
            Console.WriteLine("Доставка пiци:" + time);

        }      
        public PizzaOrder(string name, int price, int quantity, string size)
        { 
            Name = name;            
            Quantity = quantity;            
            Size = size;
            Price = price;
            if (size == "Large")
            {
                Price += 20;
                Siize = 35;

            }
            else if(size == "Medium")
            {
                Price += 10;
                Siize = 30;
            }
            else if(size == "Small")
            {
                Price += 5;
                Siize = 25;
            }            
        }// Constructor
    }

    class SushiOrder : FoodOrder
    {
        private protected int Sets{get; set;}
        public override void CalculateTotalPrice()
        {
            Money = Price * Quantity * Sets;
            Console.WriteLine("Вартiсть суш: " + Money);
        }
        public override void GetDeliveryTime() 
        {
            int time = 30 * Sets;
            Console.WriteLine("Доставка суш: " + time);

        } // Interface method implementation
        
        public SushiOrder(string name, int price, int quantity, int sets)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Sets = sets;
        }// Constructor
    }

    class HealtyOrder : FoodOrder
    {
        public override void CalculateTotalPrice()
        {
            Money = Price * Quantity + MoreMoney;
            Console.WriteLine("Вартiсть здорової їжi: " + Money);
        }
        public override void GetDeliveryTime() 
        { 
            int time = 20;
            if(MoreMoney>0)
                time += 10;
            Console.WriteLine("Доставка здорової їжi: " + time);


        }
        private protected int MoreMoney { get; set; }
        public HealtyOrder(string name, int price, int quantity, string moreMoney)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            if (moreMoney != null)
                MoreMoney += 40;
         

        }// Constructor
    }
}
