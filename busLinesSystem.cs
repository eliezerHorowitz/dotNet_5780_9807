using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_9807
{
    class busLinesSystem: IEnumerable<busLine>
    {

       public List<busLine> allBus = new List<busLine>();
        


        public void add(busLine nb)
        {
            allBus.Add(nb);
        }

        public void remove(busLine nb)
        {
            int index = allBus.IndexOf(nb);
            allBus.RemoveAt(index);
        }

        public List<busLine> findLine(int bsN)
        {
            List<busLine> myList = new List<busLine>();

            var it1 = allBus.GetEnumerator();

            while (it1.MoveNext())
            {
                var it2 = it1.Current.myStations.GetEnumerator();

                while (it2.MoveNext())
                {
                    if (it2.Current.bS.stationCode == bsN)
                        myList.Add(it1.Current);

                }
                
            }
            try
            {
                _ = myList.Count() == 0;

            }
            catch
            {
                Console.WriteLine(" no result");
            }
            return myList;
        }

        public IEnumerator<busLine> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
