using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class Book
    {
        private string title;
        private string author;
        private double price;
        private string isbn;
        public Book(string title, string author, double price, string isbn)
        {
            
            this.title = title;
            this.author = author;
            this.price = price;
            this.isbn = isbn;
            
           // printInfomation();
        }
        
        public void printInfomation()//Book[] bookss
        {
            //“title written by author is price, with ISBN isbn”
           //foreach (var title in bookss)

                Console.WriteLine("{0} written by {1} is {2} dollars, with ISBN {3}\n", title, author, price, isbn);
        }
        public string Title
        {
            // get accessor is read
            //set accessor is write
            get
            {
                return this.title;

            }
            

        }
        public string Author
        {
            get
            {
                return this.author;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
        }
        public string ISBN
        {
            get
            {
                return this.isbn;
            }
        }
        public static int CompareByPrice(Book book1, Book book2)
        {
            //return city1.Population.CompareTo(city2.Population);
            return book1.Price.CompareTo(book2.Price);
        }
        public static int CompareBytitle(Book book1, Book book2)
        {
            //return String.Compare(city1.Country + city1.City, city2.Country + city2.City);
            return String.Compare(book1.title,book2.title);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            string readdate = Console.ReadLine();
            //int olddate1 = Int32.Parse(olddate);
            string[] newdate = readdate.Split(' '); //get every data
            // get the number of books
            int books = Convert.ToInt32(newdate[0]);
			// get the choice 1 or 2
            int choice = Convert.ToInt32(newdate[1]);
			// create arry for store all data
            string[] title = new string[books];
            string[] author = new string[books];
            string[] rawprice = new string[books];
            double[] price = new double[books];
            string[] isbn = new string[books];
            Book[] bookss = new Book[books];
            //Book[] bookarray = new Book(title, author,price,isbn);
            if (choice == 1)
            {
                for ( int i = 0; i < books; i++)
                {
                    title[i] = Console.ReadLine();
                    author[i] = Console.ReadLine();
                    rawprice[i] = Console.ReadLine();
                    price[i] = Convert.ToDouble(rawprice[i]);
                    isbn[i] = Console.ReadLine();

                 }
                

                for( int i =0; i <books; i++)
                {
                    //Book booktemp = new Book(title[i], author[i], price[i], isbn[i]);
                    bookss[i] = new Book(title[i], author[i], price[i], isbn[i]);
                    //Array.Sort(bookss, Book.CompareByPrice);
                    //printInfomation(bookss);
                   // Book booktemp = new Book(title[i], author[i], price[i], isbn[i]);
                }
                Array.Sort(bookss, Book.CompareByPrice);
                for(int i = 0; i < books; i++)
                {
                    bookss[i].printInfomation();
                }
                //for (int i = 0; i< books; i++)
                //{
                //    Book booktemp = new Book(title[i], author[i], price[i], isbn[i]);
                //}
                // for( int i = 0; i < books; i++)
                //{
                //    Console.WriteLine("{0}", title[i]);
                //    Console.WriteLine("{0}", author[i]);
                //    Console.WriteLine("{0}", price[i]);
                //    Console.WriteLine("{0}", isbn[i]);
                //}


            }
            if (choice == 2)
            {
               
                string titletemp = string.Empty;
                for (int i = 0; i < books; i++)
                {
                    title[i] = Console.ReadLine();
                    author[i] = Console.ReadLine();
                    rawprice[i] = Console.ReadLine();
                    price[i] = Convert.ToDouble(rawprice[i]);
                    isbn[i] = Console.ReadLine();
                }
                for (int i = 0; i < books; i++)
                {
                    //Book booktemp = new Book(title[i], author[i], price[i], isbn[i]);
                    bookss[i] = new Book(title[i], author[i], price[i], isbn[i]);
                   // Array.Sort(bookss, Book.CompareBytitle);
                    //printInfomation(bookss);
                    // Book booktemp = new Book(title[i], author[i], price[i], isbn[i]);
                }
                Array.Sort(bookss, Book.CompareBytitle);
                for (int i = 0; i < books; i++)
                {
                    bookss[i].printInfomation();
                }






            }
            
            Console.ReadLine();
        }
    }
}
