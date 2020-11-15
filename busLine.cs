using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_9807
{
    class busLine : IComparable
    {
        int busNumber;
        BusLineStation firstStation;
        BusLineStation lastStation;
        public List<BusLineStation> myStations = new List<BusLineStation>();

        public busLine(int bN, BusLineStation fS, BusLineStation lS )
        {
            busNumber = bN;
            firstStation = fS;
            lastStation = lS;
            myStations.Add(fS);
            myStations.Add(lS);

        }


        public override string ToString()
        {
            Console.WriteLine("bus number: " + busNumber + "bus stations: ");
            int count = myStations.Count;

            for(int i = 0; i < count; ++i)
            {
                Console.WriteLine(myStations[i].bS.stationCode);
            }
            return base.ToString();
        }


        public void add(BusLineStation bls, int index)
        {
            
                myStations.Insert(index, bls);
        }


        public void remove(int index)
        {

            myStations.RemoveAt(index);
        }


        public bool chek(BusLineStation bls)
        {
            return myStations.Contains(bls);
        }


        public static double distanse(busLine bL, BusLineStation source, BusLineStation target)
        {
            int index1 = bL.myStations.IndexOf(source);
            int index2 = bL.myStations.IndexOf(target);
            ////צריך לתקן ע"י שסוכמים את כל המרחקים


            return Math.Sqrt((bL.myStations[index2].bS.Latitude- bL.myStations[index1].bS.Latitude)* (bL.myStations[index2].bS.Latitude - bL.myStations[index1].bS.Latitude)+((bL.myStations[index2].bS.Longitude - bL.myStations[index1].bS.Longitude) * (bL.myStations[index2].bS.Longitude - bL.myStations[index1].bS.Longitude)));
        }


        public double Time( BusLineStation source, BusLineStation target)
        {
            int index1 = this.myStations.IndexOf(source);
            int index2 = this.myStations.IndexOf(target);
            double count = 0;
            for(int i = index1; i < index2; ++i)
            {
                count += this.myStations[i].time;
            }
            return count;

        }

        public static busLine route(busLine bL, BusLineStation source, BusLineStation target)
        {
            int index1 = bL.myStations.IndexOf(source);
            int index2 = bL.myStations.IndexOf(target);
            busLine newBus = new busLine(0, source, target);
            for (int i = index1; i < index2; ++i)
            {
                newBus.myStations.Add(bL.myStations[i]);
            }
            return newBus;
        }



        public busLine Compare(object obj, BusLineStation source, BusLineStation target)
        {
            busLine other = (busLine)obj;
            if (this.Time(source, target) > other.Time(source, target))
                return other;
            else if (this.Time(source, target) <= other.Time(source, target))
                return this;
            

                throw new NotImplementedException();

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    } 
}
