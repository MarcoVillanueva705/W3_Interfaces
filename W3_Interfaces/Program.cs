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
            void run();//interface method does not have a body
        }
        //It is considered good practice to start with the letter "I" at the beginning of an interface, 
        //as it makes it easier for yourself and others to remember that it is an interface and not a class.


        //Note: Interfaces can contain properties and methods, but not fields.

        //The interface must be "implemented" (kind of like inherited) by another class. 

        //interface
        interface IAnimal
        {
            void animalSound();
        }

        //To implement an interface, use the : symbol (just like with inheritance).

        //Lemur 'implements' the IAnimal interface

        class Lemur : IAnimal
        {
            public void animalSound()
            {
                //the body of animalSound() goes here
                Console.WriteLine("The lemur goes...fwark!");
            }
        }

        //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

        //To create an enum, use the enum keyword (instead of class or interface), and separate the enum items 
        //with a comma:

        enum Level
        {
            Low,
            Medium,
            High
        }

        //By default, the first item of an enum has the value 0. The second has the value 1, and so on.

        enum Months
        {
            January,
            February,
            March
        }

        //You can also assign your own enum values, and the next items will update the number accordingly:

        enum Colors
        {
            Orange,
            Green = 5,
            Purple,
            Gray
        }

        static void Main(string[] args)
        {
            Lemur myLemur = new Lemur();
            myLemur.animalSound();

            //You can access enum items with the dot syntax:

            Level myLevel = Level.High;
            Console.WriteLine(myLevel);

            //To get the integer value from an item, you must explicitly convert the item to an int:
            //output is '0'
            int myMonths = (int)Months.January;
            Console.WriteLine(myMonths);

            ////output is '6'
            int myColors = (int)Colors.Purple;
            Console.WriteLine(myColors);
        }
        //Enum is short for "enumerations", which means "specifically listed".

    }
}
