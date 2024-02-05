namespace Lab3;

internal class Program
{
    static void Main(string[] args)
    {

        //4.	To test the program, ask the user for a dog name, age and color; and create a new Dog type object from the  
        //Main of the program. Give the Dog object a name, colour and age, and then execute the getter methods to print these
        //properties and the Eat methods.

        //Dog
        Console.WriteLine("Hello!!!\n" +
            "Please enter the dog name: ");
        string dogName = Console.ReadLine();

        Dog inputDog = new Dog
        {
            Name = dogName
        };

        Console.WriteLine($"Please now, enter the color of {dogName}: ");
        inputDog.Color = Console.ReadLine();

        Console.WriteLine($"Enter the age of {dogName}: ");
        inputDog.Age = int.Parse(Console.ReadLine());


        Console.WriteLine(inputDog.ToString());

        inputDog.Eat();

        //Cat
        Console.WriteLine("\nHello!!!\n" +
            "Please enter the cat name: ");
        string catName = Console.ReadLine();

        Cat inputCat = new Cat
        {
            Name = catName
        };

        Console.WriteLine($"Please now, enter the color of {catName}: ");
        inputCat.Color = Console.ReadLine();

        Console.WriteLine($"Enter the age of {catName}: ");
        inputCat.Age = int.Parse(Console.ReadLine());


        Console.WriteLine(inputCat.ToString());

        inputCat.Eat();
    }
}
