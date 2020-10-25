using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Progrem
    {

        public static void Main(string[] args)
        {
            bool[,] calendar = new bool[12, 31];

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    calendar[i, j] = false;
                };
            };
            int choice;
            do
            {
               
                Console.Write(@"Hello visitor: 
for invitations to press 1
To view a calendar to press 2
for Annual Occupanc press 3
to quit press 4");
                Console.WriteLine( );
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {


                    case 1:
                        orderVacation(calendar);
                        break;
                    case 2:
                        viewCalender(calendar);
                        break;
                    case 3:
                        tonnage(calendar);
                        break;
                        
                }

                
             
            } while (choice != 4);
            Console.ReadKey();
        }
/// <summary>
/// this function output a year-tonnag 
/// </summary>
/// <param name="calendar"></pcalender of the hotel tannage>
        private static void tonnage(bool[,] calendar)
        {
            float counter = 0;
            for(int i = 0; i< 12; ++i)
            {
                for(int j = 0; j < 31; ++j)
                {
                    if (calendar[i, j] == true)
                    {
                        counter++;
                    }
                }
                

            }
            Console.WriteLine("The occupancy of the hotel is;" + counter + " days");
            Console.WriteLine("The hotel occupancy rate is:" + (counter / 372) * 100 + '%');
            //throw new NotImplementedException();
        }


/// <summary>
/// this function output the calender of the tannege
/// </summary>
/// <param name="calendar"></param>
        private static void viewCalender(bool[,] calendar)
        {
            bool chek = true;
            for(int i = 0; i < 12; ++i)
            {
                for(int j = 0; j < 31 ; ++j)
                {
                    if(calendar[i,j]== true)
                    {
                        Console.WriteLine("start of vacation is " + (j+1) + '.' + (i+1));
                        for(int k = i; k< 12; ++k)
                        {
                            for(int l = j; l < 31; ++l)
                            {
                              
                                    if (calendar[k+(l+1)/31, (l+1)%31] == false)
                                {
                                    Console.WriteLine("the end of vacation is " + (l+1) + '.' +(k+1));
                                    i = k;
                                    j = l;
                                    k = 11;
                                    l = 30;
                                    chek = false;
                                }
                                    
                                
                            }
                            if(chek == true)
                            {
                                j = 0;
                            }
                        }
                    }
                }
            }
           
           // throw new NotImplementedException();
        }


        /// <summary>
        /// this function give to the visitor ability to order vacation
        /// </summary>
        /// <param name="calendar"></param>
        public static void orderVacation(bool[,] calendar)
        {

            int day, month, during;

            do
            {
                Console.WriteLine("enter day of start vacation:");
                day = int.Parse(Console.ReadLine());
            } while (day < 1 || day > 31);
            do
            {
                Console.WriteLine("enter month of start vacation:");
                month = int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);

            do
            {
                Console.WriteLine("enter during of  vacation:");
                during = int.Parse(Console.ReadLine());
            } while (during < 1 || ((month-1)*31 + day + during > 372)  );//Check with there is an exception to the order beyond the current year

            bool chek= true;
            for (int i = 1; i < during - 1; ++i)
            {

                if (calendar[ month - 1 + (day - 1 + i) / 31, (day - 1 + i) % 31] == true)
                {
                    chek = false;
                    Console.WriteLine("The application was rejectel");
                    break;
                }
               
                }
            if(chek == true)
            {
                for (int i = 0; i < during; ++i)
                {
                    calendar[month - 1 + (day - 1 + i) / 31, (day - 1 + i) % 31] = true;
                }
                Console.WriteLine("the invitation is confirmed");
            }
                //   throw new NotImplementedException();
            }
        }
    }


        
       
        
    

