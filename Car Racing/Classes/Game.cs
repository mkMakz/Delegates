using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
 

    public class Game
    {
        int mile = 100;
        private Car winner;

        public void ReadyToStart(SportCar sp, SportCar sp2)
        {
            winner = (Car)null;
            sp.Ready += CarReady;
            sp2.Ready += CarReady;
            sp.Driving += CarDriving;
            sp2.Driving += CarDriving;
            sp.Finish += CarFinish;
            sp2.Finish += CarFinish;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Get redy");

            sp.GetReady();
            sp2.GetReady();

            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Set");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!!!");
            Thread.Sleep(800);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            for (float t = 0; ; t += 0.1F)
            {
                Console.SetCursorPosition(0, 0); 

                Console.WriteLine($"Time {TimeSpan.FromSeconds(t)}");
                sp.Drive(t, 400);
                sp2.Drive(t, 400);
                Thread.Sleep(100);
                if (winner != null)
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The winner is " + winner.Name);
        }

        private void CarFinish(Car car)
        {
            winner = car;
        }

        private void CarDriving(Car car, float distance)
        {
            Console.WriteLine("Car " + car.Name + " distanse " + distance);
        }

        private void CarReady(Car car)
        {
            Console.WriteLine("The car " + car.Name + " Is ready");
        }

    }
}
