using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictonarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> personer = new Dictionary<string, int>(); // new dictonary where our key is a String and value is a int

            personer.Add("Emil", 21); // adds persons
            personer.Add("Lars", 40);

            foreach (var item in personer) // write all persons where key is emil 
            {
                if (item.Key == "Emil")
                {
                Console.WriteLine(item.Key + " " + item.Value);
                }

                else // else say he no he dosent exist 
                {
                    Console.WriteLine("no");
                }

            }

            if (personer.Remove("Emil")) // removing emil if it exist 
            {
                Console.WriteLine("removed Emil");
            }
            else // if emil dident exist say we couldent find emil 
            {
                Console.WriteLine("kunne ikke finde 'Emil' ");
            }

            foreach (var item in personer) // prints all persons where key is emil and also prints age of emils 
            {
                if (item.Key == "Emil")
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }

                else
                {
                    Console.WriteLine(item.Key + " " + item.Value); // prints every other person
                }

            }



        }
    }
}
