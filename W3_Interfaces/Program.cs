using System;

namespace W3_Interfaces
{
    //Another way to achieve abstraction in C#, is with interfaces.

    // An interface is a completely "abstract class", which can only contain 
    //abstract methods and properties(with empty bodies) :
    class Program
    {
        //interface
        interface Animal
        {
            void AnimalSound();//nterface method does not have a body
            void run();//nterface method does not have a body
        }
        //It is considered good practice to start with the letter "I" at the beginning of an interface, 
        //as it makes it easier for yourself and others to remember that it is an interface and not a class.


        //Note: Interfaces can contain properties and methods, but not fields.


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
