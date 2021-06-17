using System;
using System.IO;
using System.Diagnostics;


namespace ElevatorLibrary
{
    public class ElevatorMethods {

        public int gotoFloor (int flnr) {
            return flnr;
        }

        public bool showElevatorControllPanel(){
            bool exit = false;
            Console.WriteLine("Hi");
            Console.ReadKey();
            Console.Clear();
            return exit;
        }

        public string elevatorDirection (int flnr) {
            string direction = "";
            return direction;

        }

        public string estimatedTime () {
            return "";
        }

        public void stop(){

        }
    }
    
}