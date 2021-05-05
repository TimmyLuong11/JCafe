using System;
using System.Collections.Generic;

namespace JCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declearing Variables
            Dictionary<string, List<Cafe>> CustNam= new Dictionary<string, List<Cafe>>(); //Keep tack of each orders for each person
            string name, answer, food, drink = string.Empty, toppings = string.Empty;
            double total, price, amount = 0, sum = 0;
            Cafe C = new Cafe();

            //Welcoming the user
            Console.WriteLine("**. **. **Welcome to Café Penguin**.**.** ");
            
            //Loop until the user does not want to add another person 
            do
            {
                Console.WriteLine("Please type in your name >.<");
                name = Console.ReadLine();
                C.CustName = name;
                CustNam.Add(name, new List<Cafe>());

                //Loop unil the user does not want to order any more food or drinks
                do
                {
                    total = 0;
                    //Console.WriteLine(C.FoodMenu());
                    C.FoodMenu();  
                    Console.WriteLine("What would you like to order: ");
                    answer = Console.ReadLine().ToLower();
                    food = answer;
                    price = C.CalculatePrice(answer);
                    total += price;
                    Console.WriteLine("Would you like a drink: yes or no");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        C.DrinkMenu();
                        Console.WriteLine("What kind of drink would you like: ");
                        answer = Console.ReadLine().ToLower();
                        drink = answer;
                        price = C.CalculatePrice(answer);
                        total += price;
                        Console.WriteLine("Would you like toppings with your drink: yes or no:");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            C.ToppingsMenu();
                            Console.WriteLine("What kind of toppings would you like: ");
                            answer = Console.ReadLine().ToLower();
                            toppings = answer;
                            price = C.CalculatePrice(answer);
                            total += price;
                        }
                        else
                        {
                            Console.WriteLine("Cool beans! ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cool beans! ");
                    }

                    //Adding the user input to the variables in the class
                    C = new Cafe()
                    {
                        Food = food,
                        Drink = drink,
                        Toppings = toppings,
                        Amount = total,
                    };

                    //Adding the user input to the dictionary
                    CustNam[name].Add(C); 
                    
                    Console.WriteLine($"Would you like to order anything else: ");
                    answer = Console.ReadLine();
                } while (answer.ToLower() == "yes");
                
                Console.WriteLine("Would you like to order for another person: ");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            //Looping through the  key in the dictionary
            foreach (var item in CustNam)
            {
                //Reset the total when calcuating for the person
                sum = 0;
                Console.WriteLine($"{item.Key}'s order is:");

                //Looping through the values at each key out put the user what they order and have a running total
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine(item.Value[i]);
                    amount = C.RunningTotal(item.Value[i]);
                    sum += amount;
                }

                //Output grand total
                C.Receipt(sum);
                Console.WriteLine(); 
            }
        }
    }
}
