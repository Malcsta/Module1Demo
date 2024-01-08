using System;
using System.Runtime.Remoting.Messaging;
using Appliances.Cooling;
using System.Threading;

namespace FTE2Module1Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //New Variable of Fan type
            Fan Fan1;

            //Defining Fan1 as an instance of a Fan with default values
            Fan1 = new Fan(10.2, FanColor.Black);

            //Printing Fan1's size and color
            Console.WriteLine(Fan1.GetSize());
            Console.WriteLine(Fan1.GetColor());

            //Setting Fan1's color to green, verifying change
            Fan1.SetColor(FanColor.Green);
            Console.WriteLine(Fan1.GetColor());

            //Increasing Fan1's speed amd verifying that it worked
            Fan1.IncreaseSpeed();
            Console.WriteLine(Fan1.GetSpeed());

            //Declaring variable of FanSpeed, defining it as fast
            FanSpeed newSpeed = FanSpeed.Fast;

            //Setting Fan1's speed to the newSpeed variable
            Fan1.SetSpeed(newSpeed);

            //Declaring another variable of Fan type in default state
            Fan fan2 = new Fan();

            //Printing fan2's state
            Console.WriteLine(fan2.ToString());
            string response = Console.ReadLine();

            //Further experiments
            bool UserActive = true;
            while (UserActive)
            {
                Console.WriteLine("Press 1 to increase fan speed.");
                Console.WriteLine("Press 2 to decrease fan speed.");
                response = Console.ReadLine();
                response = response.ToString();
                if (response == "1")
                {
                    Fan1.IncreaseSpeed();
                }
                else if (response == "2")
                {
                    Fan1.DecreaseSpeed();
                }
                Console.WriteLine(Fan1.ToString());
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
    }
}
