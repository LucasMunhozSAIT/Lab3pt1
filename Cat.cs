using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Cat : Animal
    {
        public Cat()
        {

        }

        //3.	Create a Cat class that implements the above Animal class and the Eat method that prints “Cats eat mice.”
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public override string ToString()
        {
            return $"\nCat information:\n" +
                $"Name: {Name}.\n" +
                $"Color: {Color}.\n" +
                $"Age: {Age}.";
        }
    }
}
