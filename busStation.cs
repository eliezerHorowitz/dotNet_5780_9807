using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_9807
{
    class busStation
    {
        public int stationCode;
        public double Latitude{ get; set; }
        public double Longitude { get; set; }
        static Random r = new Random();

        public busStation(int sC)
        {
            stationCode = sC;
            Latitude = r.Next(-180, 181) + (float)r.Next(0, 101)/100000;
            Longitude = r.Next(-360, 361) + (float)r.Next(0, 101) / 100000;


        }

        public override string ToString()
        {
            Console.WriteLine("Bus Station Code:" + stationCode + ".  " + Latitude + "°N " + ".  " + Longitude + "°E");
            return base.ToString();
        }


    }
}
