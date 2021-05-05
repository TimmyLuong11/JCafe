using System;
using System.Collections.Generic;
using System.Text;

namespace JCafe
{
    class Cafe
    {
        //Declaring the public and const variables
        const double taxrate = 0.055;
        public string CustName { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public string Toppings { get; set; }
        public double Amount { get; set; }

        /// <summary>
        /// The default constructor setting public variables to either empty string or 0
        /// </summary>
        public Cafe()
        {
            CustName = string.Empty;
            Food = string.Empty;
            Drink = string.Empty;
            Toppings = string.Empty;
            Amount = 0;
        }

        /// <summary>
        /// Display the food menu
        /// </summary>
        public void FoodMenu()
        {
            Console.WriteLine(
                               "\n\tFood:" +

                                "\n\tVietnamese Pizza------$10.00" +

                                "\n\tPho-----------------------$15.00" +

                                "\n\tEggrolls---------------$5.00" +

                                "\n\tBanh Mi--------------$8.00"); ;
        }

        /// <summary>
        /// Display the drink menu
        /// </summary>
        public void DrinkMenu()
        {
            Console.WriteLine(
                               "\n\tDrinks:" +

                                "\n\tBrown Sugar Boba------$3.50" +

                                "\n\tTaro Milk Tea----------------$4.00" +

                                "\n\tHoneydew Milk Tea------------$4.00" +

                                "\n\tVietnamese Coffee----------$3.00");
        }

        /// <summary>
        /// Display the toppings menu
        /// </summary>
        public void ToppingsMenu()
        {
            Console.WriteLine("\n\tToppings:" +
                            "\n\tTapioca----0.50" +
                            "\n\tJelly-----0.50" +
                            "\n\tPopping Boba---0.50");
        }

        /// <summary>
        /// Take the wanted item and find the price
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Return the price of the item</returns>
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
                price = 3.50;
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

        /// <summary>
        /// Calculate the total for each item
        /// </summary>
        /// <param name="subtotal"></param>
        public void Receipt(double subtotal)
        {
            double tax = subtotal * taxrate;
            double total = tax + subtotal;
            Console.WriteLine($"Subtotal of your item(s) is {subtotal.ToString("C")}");
            Console.WriteLine($"Tax of your item(s) is {tax.ToString("C")}");
            Console.WriteLine($"Total  of your item(s) is {total.ToString("C")}");
        }
        
        /// <summary>
        /// Output the string of orders
        /// </summary>
        /// <returns>The string of orders</returns>
        public override string ToString()
        {
            return $"{Food} \n{Drink} \n{Toppings}";
        }

        /// <summary>
        /// Gets the amount when looping through the key values
        /// </summary>
        /// <param name="subtotal"></param>
        /// <returns>The cost of each item</returns>
        public double RunningTotal(Cafe subtotal)
        {
            return subtotal.Amount;
        }
    }
}