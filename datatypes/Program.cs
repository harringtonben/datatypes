using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var strang = new List<string>();
            strang.Add("this is a string");
            strang.Remove("this is a string");
            strang.AddRange(new List<string> { "asdf", "ben", "asdf" });
            var shouldbefalse = strang.Contains("this is a string");

            var myDictionary = new Dictionary<string, int>();
            myDictionary.Add("firstKey", 123456);
            var myValue = myDictionary["firstKey"];
            //Console.WriteLine(myValue);
            //Console.Read();

            //var classDictionary = new Dictionary<string, Food>();
            //classDictionary.Add("food1", new Food { Name = "Carrot", GlutenFree = true });
            //classDictionary.Add("food2", new Food { Name = "Bread", GlutenFree = false });
            //classDictionary.Add("food3", new Food { Name = "Chicken", GlutenFree = true });
            //classDictionary.Add("food4", new Food { Name = "Chips", GlutenFree = false });
            //classDictionary.Add("food5", new Food { Name = "Pickles", GlutenFree = true });

            var classDictionary = new Dictionary<string, Food>
            {
                {"food1", new Food { Name = "Carrot", GlutenFree = true }},
                { "food2", new Food { Name = "Bread", GlutenFree = false } },
                { "food3", new Food { Name = "Chicken", GlutenFree = true }},
                { "food4", new Food { Name = "Chips", GlutenFree = false } },
                { "food5", new Food { Name = "Pickles", GlutenFree = true } }
            };

            if (classDictionary.ContainsKey("ads;ljkjas;lkjfas"))
            {
                Console.WriteLine("Never going to get here");
            }

            foreach (var food in classDictionary.Values)
            {
                Console.WriteLine($"Food is {food.Name}");
            }

            foreach (var key in classDictionary.Keys)
            {
                Console.WriteLine($"key is {key}");
            }

            foreach (var item in classDictionary)
            {
                Console.WriteLine($"{item.Key} is the value for {item.Value.Name}");
            }

            var newFoodThing = new Food { Name = "Pizza", GlutenFree = false };
            newFoodThing.GetHashCode();
            var sameThing = newFoodThing;

            if (newFoodThing.GetHashCode() == sameThing.GetHashCode())
            {
                Console.WriteLine("told you so.");
                Console.WriteLine(newFoodThing.GetHashCode());
            }

            var hashset = new HashSet<Food>();
            hashset.Add(new Food { Name = "Broccoli", GlutenFree = true });
            

            Console.Read();
        }
    }
}
