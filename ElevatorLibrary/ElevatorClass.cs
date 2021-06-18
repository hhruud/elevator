using System;
using System.Linq;
using System.Threading;


namespace ElevatorLibrary
{
    public class ElevatorMethods
    {

        public int gotoFloor(int currentFloor)
        {
            var dir = "";
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };
            array2 = array2.Where(e => e != currentFloor).ToArray();
            Console.WriteLine("Hi, You are now in " + currentFloor + " floor");
            Console.WriteLine("which floor do you want to go to?");
            for (int i = 0; array2.Length > i; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine("Type a floornumber, and then press Enter: ");
            var floorNumber = Convert.ToInt32(Console.ReadLine());
            if(floorNumber > 0 && floorNumber < 7 && floorNumber != currentFloor) {
                dir = elevatorDirection(floorNumber, currentFloor);
            }

            Console.WriteLine("Going " + dir + " to " + floorNumber + " floor");
            var time = estimatedTime(floorNumber, currentFloor);
            
            Console.WriteLine("Estimated time is... " + time + " seconds");
            Thread.Sleep(5000);
            
            Console.Clear();
            return floorNumber;
        }

        public string elevatorDirection(int floorNumber, int currentFloor)
        {   
            var direction = "down";
            if(floorNumber > currentFloor) {
                direction = "up";
            }
            return direction;
        }

        public string estimatedTime(int floorNumber, int currentFloor)
        {   
            //default time in seconds
             int defaultTime = 10;
             int diff = System.Math.Abs(floorNumber - currentFloor);
             decimal v = Decimal.Add(1, diff);
             string time = (defaultTime * v).ToString();
            return time;
        }

        public void stop()
        {

        }
    }

}