using System;
using System.Collections.Generic;
using System.Text;

namespace JCafe
{
    class Cafe
    {
        const double taxrate = 0.055;
        public string CustName { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public string Toppings { get; set; }
        public double Amount { get; set; }

        public Cafe()
        {
            CustName = string.Empty;
            Food = string.Empty;
            Drink = string.Empty;
            Toppings = string.Empty;
            Amount = 0;
        }

        public string FoodMenu()
        {
            string food = (
                               "\n\tFood:" +

                                "\n\tVietnamese Pizza------$10.00" +

                                "\n\tPho-----------------------$15.00" +

                                "\n\tEggrolls---------------$5.00" +

                                "\n\tBanh Mi--------------$8.00");
            return food;
        }
        public string DrinkMenu()
        {
            string drink = (
                               "\n\tDrinks:" +

                                "\n\tBrown Sugar Boba------$3.50" +

                                "\n\tTaro Milk Tea----------------$4.00" +

                                "\n\tHoneydew Milk Tea------------$4.00" +

                                "\n\tVietnamese Coffee----------$3.00");



            return drink;
        }
        public string ToppingsMenu()
        {
            string Tops =

                            ("\n\tToppings:" +
                            "\n\tTapioca----0.50" +
                            "\n\tJelly-----0.50" +
                            "\n\tPopping Boba---0.50");
            return Tops;
        }

        public double CalculatePrice(string item)
        {

            double price = 0;
            if (item == "vietnamese pizza")
            {
                price = 10.00;
            }
            else if (item == "pho")
            {
                price = 15.00;
            }
            else if (item == "eggrolls")
            {
                price = 5.00;
            }
            else if (item == "banh mi")
            {
                price = 8.00;
            }
            else if (item == "brown sugar boba")
            {
                price = 4.00;
            }
            else if (item == "taro milk tea")
            {
                price = 4.00;
            }
            else if (item == "honeydew milk tea")
            {
                price = 4.00;
            }
            else if (item == "vietnamese coffee")
            {
                price = 3.00;
            }
            else if (item == "tapioca")
            {
                price = 0.50;
            }
            else if (item == "jelly")
            {
                price = 0.50;
            }
            else if (item == "popping boba")
            {
                price = 0.50;
            }
            return price;
        }
        public void Receipt(Cafe subtotal)
        {
            double tax = subtotal.Amount * taxrate;
            double total = tax + subtotal.Amount;
            Console.WriteLine($"Subtotal of your item(s) is {subtotal.Amount.ToString("C")}");
            Console.WriteLine($"Tax of your item(s) is {tax.ToString("C")}");
            Console.WriteLine($"Total  of your item(s) is {total.ToString("C")}");
        }
        public string DisplayOrder(string item)
        {
            //Console.WriteLine($"You ordered:\n{item}");
            return ($"You ordered:\n{item}");
            //return $"{item.Food} \n{item.Drink} \n{item.Toppings}";
        }

        public override string ToString()
        {
            return $"{Food} \n{Drink} \n{Toppings}";
        }
    }
}