using Car_Racing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing
{
   
    class Program
    {
        delegate void GetToStart();
        delegate void StartRacing();

        static void Main(string[] args)
        {
            Game g = new Game();
            SportCar sp1 = new SportCar();
            SportCar sp2 = new SportCar();

            g.ReadyToStart(sp1, sp2);

            Console.ReadKey();
        }
    }
}
