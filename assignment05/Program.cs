using System.Drawing;
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


            static void Printbookinfo(string Title, int Pages = 300)
            {

                Console.WriteLine($"title: {Title}, pages: {Pages}");



            }

            static void Main(string[] args2)
            {

                Printbookinfo("cleancode");

                Printbookinfo("C programming", 600);
            }





            #endregion






















        }
    }
}
