using System;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void DisplayLunches(params LunchDemos[] lunches)
            {
                foreach (var lunch in lunches)
                {
                    Console.WriteLine($"entree: {lunch.Entree}, side dish: {lunch.SideDish}, drink: {lunch.Drink}");
                }
            }

            static void Main(string[] args)
            {
                LunchDemos lunch1 = new LunchDemos("grilled chicken", "caesar salad", "lemonade");
                LunchDemos lunch2 = new LunchDemos("vegetable stir fry", "rice", "green tea");
                LunchDemos lunch3 = new LunchDemos("cheeseburger", "fries", "coke");
                
                Console.WriteLine("lunch menu:");
                DisplayLunches(lunch1);
                DisplayLunches(lunch1, lunch2);
                DisplayLunches(lunch1, lunch2, lunch3);
            }



        }
    }
}
