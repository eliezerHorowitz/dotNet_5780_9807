using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_9807
{
    class BusLineStation
    {
        public busStation bS;
        public double time;
        public double distanse{ get; set; }

        public BusLineStation(busStation bS1, float t, busStation fS)
        {
            bS = bS1;
            time = t;
            
            distanse  = Math.Sqrt(((fS.Latitude - bS.Latitude) * (fS.Latitude - this.bS.Latitude)) + ((fS.Longitude - this.bS.Longitude) * (fS.Longitude - this.bS.Longitude)));
            

        }


    }
}
