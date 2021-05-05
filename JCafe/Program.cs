using System;
using System.Collections.Generic;

namespace JCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Cafe>> CustNam= new Dictionary<string, List<Cafe>>();
            //List<Cafe> custOrder = new List<Cafe>();
            string name, answer, response, order = string.Empty, food = string.Empty, drink = string.Empty, top = string.Empty;
            double total = 0, price = 0;


            Cafe C = new Cafe();

            Console.WriteLine("**. **. **Welcome to Café Penguin**.**.** ");

            //figure out how to add name into list
            do
            {

                Console.WriteLine("Please type in your name >.<");
                name = Console.ReadLine();
                C.CustName = name;
                CustNam.Add(name, new List<Cafe>());

            do
            {
                total = 0;
                Console.WriteLine(C.FoodMenu());
                Console.WriteLine("What would you like to order: ");
                answer = Console.ReadLine().ToLower();
                food = answer;
                price = C.CalculatePrice(answer);
                total += price;
                Console.WriteLine("Would you like a drink: yes or no");
                response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    Console.WriteLine(C.DrinkMenu());
                    Console.WriteLine("What kind of drink would you like: ");
                    answer = Console.ReadLine().ToLower();
                    drink = answer;
                    price = C.CalculatePrice(answer);
                    total += price;

                }
                else
                {
                    Console.WriteLine("Cool beans! ");
                }
                Console.WriteLine("Would you like toppings with your drink: yes or no:");
                response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    Console.WriteLine(C.ToppingsMenu());
                    Console.WriteLine("What kind of toppings would you like: ");
                    answer = Console.ReadLine().ToLower();
                    top = answer;
                    //custOrder.Add(C);
                    price = C.CalculatePrice(answer);
                    total += price;
                }
                else
                {
                    Console.WriteLine("Cool beans! ");
                }
                C = new Cafe()
                {
                    Food = food,
                    Drink = drink,
                    Toppings = top,
                    Amount = total,
            };
                    CustNam[name].Add(C); 
                //custOrder.Add(C);
                C.Amount = total;

                Console.WriteLine($"Would you like to order anything else: ");
                order = Console.ReadLine();
            } while (order.ToLower() == "yes");
                Console.WriteLine("would you like to another perosn");
                order = Console.ReadLine();
            } while (order.ToLower() == "yes");
            //portion that would allow the food and drink menu


            //output the receipt total and the user's name

            foreach (var item in CustNam)
            {
            Console.WriteLine($"{item.Key}'s order is:");
            for (int i = 0; i < item.Value.Count; i++)
            {
                Console.WriteLine(item.Value[i]);
                C.Receipt(item.Value[i]);
            }
             }
        }
    }
}
