using System;
using System.Linq;
using System.Threading;


namespace ElevatorLibrary
{
    public class ElevatorMethods
    {
        public int gotoFloor(int currentFloor)
        {
            var direction = "";
            init(currentFloor);

            try
            {
                var floorNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (floorNumber > 0 && floorNumber < 7 && floorNumber != currentFloor)
                {
                    direction = elevatorDirection(floorNumber, currentFloor);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Between 1 and 6 please, and not the current floor");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return currentFloor;
                }

                Console.WriteLine("Going " + direction + " to " + floorNumber + numberplace(floorNumber) + " floor");
                var time = estimatedTime(floorNumber, currentFloor);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Estimated time is... {time} seconds\n");
                Console.Write("Press any key, to STOP");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                return floorNumber;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Not a number i think...");
                Thread.Sleep(2000);
                Console.Clear();
                return 1;
            }
        }

        public void init(int currentFloor)
        {

            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };
            array2 = array2.Where(e => e != currentFloor).ToArray();
            Console.WriteLine("Hi, You are now in " + currentFloor + numberplace(currentFloor) + " floor");
            Console.WriteLine("which floor do you want to go to?");

            for (int i = 0; array2.Length > i; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine("Type a floornumber, and then press Enter: ");
        }

        public string elevatorDirection(int floorNumber, int currentFloor)
        {
            var direction = "down";
            if (floorNumber > currentFloor)
            {
                direction = "up";
            }
            return direction;
        }

        public int estimatedTime(int floorNumber, int currentFloor)
        {
            //default time in seconds for moving 1 floor
            int defaultTime = 3;
            //then 2 seconds for all floors to come
            int diff = System.Math.Abs(floorNumber - currentFloor);
            int time = (defaultTime + (diff * 2));
            return time;
        }

        public void stop()
        {

        }

        public string numberplace(int floorNumber)
        {
            string place = "";
            switch (floorNumber)
            {
                case 1:
                    place = "st";
                    break;
                case 2:
                    place = "nd";
                    break;
                case 3:
                    place = "rd";
                    break;
                default:
                    place = "th";
                    break;
            }
            return place;
        }

    }

}