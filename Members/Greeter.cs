using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Members
{
    public class greeter
    {
        //field - private variable, only used inside this class
        //usually we put _ before private variables
        private Random _rng = new Random();

        //Method:
        //1 - access modifier - where in our code can this be accessed?
        //2 - return type - the type of value the method returns
        //3 - "signature" = name + parameters (input)
        //4 - body (where all the action happens)
        //1     2     3a          3b
        public void SayHello(string name)
        {
            //4
            Console.WriteLine($"Hello, {name}!");

        }
        //overload -same name, but different (no)  parameters
        public void SayHello()
        {
            Console.WriteLine("Hey, you!");

        }
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] {"Nice to see you!", "Howdy!" , "Hola!","Bon jour!" };

            int randomNumber = _rng.Next(0, availableGreetings.Length);

            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            randomGreeting= availableGreetings[randomNumber];

            Console.WriteLine(randomGreeting);

        }
    }
}
