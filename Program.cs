using System;
using ElevatorLibrary;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorMethods elevator = new ElevatorMethods();
            
            int currentFloor = 1;
            
            while(currentFloor > 0 && currentFloor < 7) {
                currentFloor = elevator.gotoFloor(currentFloor);
            }
            Console.WriteLine("Bye");
            
        }
    }
}
