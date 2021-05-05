using System;
using System.Collections.Generic;

namespace JCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Cafe>> CustNam= new Dictionary<string, List<Cafe>>();
            string name, answer, food, drink = string.Empty, top = string.Empty;
            double total, price;

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
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
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
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine(C.ToppingsMenu());
                        Console.WriteLine("What kind of toppings would you like: ");
                        answer = Console.ReadLine().ToLower();
                        top = answer;
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
                    //C.Amount = total;
                    
                    Console.WriteLine($"Would you like to order anything else: ");
                    answer = Console.ReadLine();
                } while (answer.ToLower() == "yes");
                
                Console.WriteLine("Would you like to order for another person: ");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");
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
