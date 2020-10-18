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

        static void Main(string[] args)
        {
            Lemur myLemur = new Lemur();
            myLemur.animalSound();
        }
    }
}
