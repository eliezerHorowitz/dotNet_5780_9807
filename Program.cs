using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_9807
{
    class Program
    {
        static void Main(string[] args)
        {
            busLinesSystem mySystem = new busLinesSystem();

            for (int i = 0; i < 10; ++i)
            {
                mySystem.allBus.Add(new busLine(i + 1, new BusLineStation(new busStation(i + 6), i, new busStation(i + 11)), new BusLineStation(new busStation(i + 6), i, new busStation(i + 8))));
            }
            Console.ReadKey();
            

        }
    }
}
