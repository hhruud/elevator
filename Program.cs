using System;
using ElevatorLibrary;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorMethods elevator = new ElevatorMethods();
            bool start = true;
            while(start) {
                elevator.showElevatorControllPanel();
            }

            Console.WriteLine("Bye");
            
        }
    }
}
