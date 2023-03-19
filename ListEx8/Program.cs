using System;
using System.Diagnostics.Metrics;

namespace FunwithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> foods = new List<string> { "Pizza", "Tacos", "Spaghetti", "Grapes", "Candy" };
           

           
            
            string[] foodArr = new string[] { "Pho","Ravioli", "Apples" };
            
            foods.AddRange(foodArr);
            Console.WriteLine($"The new list now has {foods.Count()} food items.");

            Console.WriteLine("-------Original List--------");
            for (int i = 0; i < foods.Count(); i++)
                Console.WriteLine(foods[i]);

      
            foods.Remove(foods[4]); // the item at index 4 is removed
           

            Console.WriteLine($"The revised list now has {foods.Count()} food items (candy was removed).");
            Console.WriteLine("-------Revised List--------");
            for (int i = 0; i < foods.Count(); i++)
                Console.WriteLine(foods[i]);

          
            foods.Reverse();
            Console.WriteLine("-------Reverse Sorted List--------");
            foreach (string m in foods)
                Console.WriteLine(m);


        }
    }
}

