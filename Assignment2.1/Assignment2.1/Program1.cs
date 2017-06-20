using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    // struct Date incluing year, month, and day. All are int type
    struct Date
    {
        enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        public int year, month, day;

        // two consructors:
        // public Date (int year, int month, int day)
        public Date(int year, int month, int day)
        {
            this.year = year; // this.year is field 
            this.month = month;
            //this.month = Convert.ToString(month);
            this.day = day;
        }
        ////public Date(string dateString).
        //public Date(string dateString)
        //{
        //    //mm/dd/yyyy
        //    string olddate = Console.ReadLine();
        //    dateString = olddate;
        //    //int olddate1 = Int32.Parse(olddate);
        //    string[] newdate = dateString.Split('/'); //get every data
        //    int[] newdate1 = new int[newdate.Length];
        //    for (int i = 0; i < newdate.Length; i++)
        //    {
        //        newdate1[i] = int.Parse(newdate[i]);
        //    }

        //    this.month = newdate1[0];
        //    this.day = newdate1[1];
        //    this.year = newdate1[2];

        //}
        // print the date
        public void printInformation()
        {
            // Console.WriteLine("Year: {0}", year);
            //Console.WriteLine("Month: {0}", month);
            //Console.WriteLine("Date: {0}", day);
            string month1 = "";

            if (this.month == 01)
            {
                month1 = Date.Months.Jan.ToString();
            }
            if (this.month == 02)
            {
                month1 = Date.Months.Feb.ToString();
            }
            if (this.month == 03)
            {
                month1 = Date.Months.Mar.ToString();
            }
            if (this.month == 04)
            {
                month1 = Date.Months.Apr.ToString();
            }
            if (this.month == 05)
            {
                month1 = Date.Months.May.ToString();
            }
            if (this.month == 06)
            {
                month1 = Date.Months.Jun.ToString();
            }
            if (this.month == 07)
            {
                month1 = Date.Months.Jul.ToString();
            }
            if (this.month == 08)
            {
                month1 = Date.Months.Aug.ToString();
            }
            if (this.month == 09)
            {
                month1 = Date.Months.Sep.ToString();
            }
            if (this.month == 10)
            {
                month1 = Date.Months.Oct.ToString();
            }
            if (this.month == 11)
            {
                month1 = Date.Months.Nov.ToString();
            }
            if (this.month == 12)
            {
                month1 = Date.Months.Dec.ToString();
            }


            Console.WriteLine("Today is {0}, {1}, {2}.\n ", month1, day, year);


        }
    }



    class Program1
    {
        //enum Months { Jan =1, Feb, mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

        static void Main(string[] args)
        {
            Date d = new Date();

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                string olddate = Console.ReadLine();
                //int olddate1 = Int32.Parse(olddate);
                string[] newdate = olddate.Split(' '); //get every data
                int[] newdate1 = new int[newdate.Length];
                for (int i = 0; i < newdate.Length; i++)
                {
                    newdate1[i] = int.Parse(newdate[i]);
                }
                //d.Date(newdate1[0], newdate1[1],newdate1[2]); //get the year from user
                d.year = newdate1[0];
                d.month = newdate1[1];
                d.day = newdate1[2];
                d.printInformation();
                //Console.WriteLine("You chose 1.");
            }
            if (choice == 2)
            {
                string olddate = Console.ReadLine();
                //dateString = olddate;
                //int olddate1 = Int32.Parse(olddate);
                string[] newdate = olddate.Split('/'); //get every data
                int[] newdate1 = new int[newdate.Length];
                for (int i = 0; i < newdate.Length; i++)
                {
                    newdate1[i] = int.Parse(newdate[i]);
                }
                d.month = newdate1[0];
                d.day = newdate1[1];
                d.year = newdate1[2];
                d.printInformation();
               // Console.WriteLine("You chose 2.");
            }
            Console.ReadLine();
        }
    }
}
