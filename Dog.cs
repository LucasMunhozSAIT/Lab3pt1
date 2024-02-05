using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dog : Animal
    {
        public Dog()
        {

        }

        //2.	Create a Dog class that implements the Animal class and the Eat method that prints “Dogs eat meat.”
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public override string ToString()
        {
            return $"\nDog information:\n" +
                $"Name: {Name}.\n" +
                $"Color: {Color}.\n" +
                $"Age: {Age}.";
        }
    }
}
