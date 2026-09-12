using System.Drawing;
using System.Numerics;
using System.Reflection;

namespace assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 
            ///   Write a method bool TryGetPrice(string title, out double price) that returns 
            //true and sets price to 25.5 if title is "Clean Code", otherwise returns false and
            // sets price to 0.Call it and print the price if found

            /*  static bool trygetprice(string Title, out double Price)
              {
                  if (Title == "Clean Code")

                  {
                      Price = 25.5;
                      return true;
                  }
                  else
                  {
                      Price = 0;
                      return false;
                  }
              }
              static void Main(string[] args)

              {

                  double price; 
                  if (trygetprice("cleancode", out price)) 
                  { 
                      Console.WriteLine(price);
                  }


              }*/

            #endregion



            #region Q2 
            ///-Write a method PrintBookInfo(string title, int pages = 300) where pages is 
            //optional.Call it once with only a title, and once passing both a title and pages. 
            /*

            static void Printbookinfo(string Title, int Pages = 300)
            {

                Console.WriteLine($"title: {Title}, pages: {Pages}");



            }

            static void Main(string[] args2)
            {

                Printbookinfo("cleancode");

                Printbookinfo("C programming", 600);
            }

            */



            #endregion



            #region Q3
            ///Using the PrintBookInfo method from the question above, call it by naming 
            // the parameters, passing pages before title
            /*
                        static void Printbookinfo(string Title, int Pages = 300)
                        {

                            Console.WriteLine($"title: {Title}, pages: {Pages}");

                        }

                        static void Main(string[] args)
                        {

                            Printbookinfo(Pages: 150, Title: "cleancode");
                        }


                    }
            */


            #endregion



            #region Q4
            ///4-Write a method PrintAllTitles(params string[] titles) that prints each title on its 
            // own line. Call it with three book titles
            /*
                        static void printalltitles(params string [] Titles)
                        {
                            foreach (string title in Titles)
                            {
                                Console.WriteLine(title);
                            }
                        }

                        static void Main(string[] args)
                        {


                            printalltitles("C# Programming", "Learn Python", "JavaScript");

                        }

                        */






            #endregion




            #region Q1 part 2
            ///-Add a private string password = "secret"; field to a Book class. Try to 
            //print it from Main  (outside the class). What happens, and why?

            /*       class book
                {
                    private string password = "Secret";
                }

                static void Main(string[] args)
                {



                       book book = new book();

                    Console.WriteLine(book.password);





                }
            */



            // result =>   error






            #endregion


            #region Q2 part 2
            ///Add an internal int copiesInStock = 5; field to Book. Print it from Main. 
            // Does it compile? Why?

            class Book
        {
            internal int Copiesinstock = 5;
        }


        static void Main(string[] args)
        {
            Book book = new Book();

            Console.WriteLine(book.Copiesinstock);


        }


        //run code success





        #endregion








    }
}
}
