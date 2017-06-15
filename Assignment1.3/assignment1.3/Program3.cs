using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4
{
    class Program
    {
        static public int Partition(double[] numbers, int left, int right)
        {

            double pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    double temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void SortQuick(double[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }

        static void Main(string[] args)
        {
            // Console.Write("\nProgram for sorting a numeric array using Quick Sorting\n");
            Console.Write("");
            int max = Convert.ToInt32(Console.ReadLine());
            //double max1 = Convert.ToDouble(max);
            double[] numbers = new double[max];
            //double[] numbers = new double[];
            string s = Console.ReadLine();
            string[] values = s.Split(' ');



            for (int i = 0; i < max; i++)
            {
                //  Console.Write("Enter"+(i + 1).ToString()+"e");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine();


                //string numbers = Console.ReadLine();
                //string numbers1 = numbers.Split(' ');


                numbers[i] = double.Parse(values[i]);


            }






            // Console.WriteLine("QuickSort");
            SortQuick(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.Write("\t " + numbers[i]);
            Console.ReadKey();

        }
    }
}
