using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program2
    {
        static public double GetGrade()
        {


            Console.Write("Enter a grade:");
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(grade);
            return grade;
        }
        static public void GetLetter()
        {
            double grade;
            grade = GetGrade();
            if (grade >= 90)
            {
                Console.WriteLine("Grade A");
            }
            if (grade >=80 && grade <90)
            {
                Console.WriteLine("Grade B");
            }
            if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("Grade C");
            }
            if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("Grade D");
            }
             if (grade >=0 && grade < 60)
            {
                Console.WriteLine("Grade F");
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            
            GetLetter();

        }
    }
}
