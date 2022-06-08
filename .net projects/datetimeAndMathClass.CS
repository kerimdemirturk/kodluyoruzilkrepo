using System;
namespace forloop
{
    class datetime
{
       static void Main(string[] args) {
         
         //datetime
         Console.WriteLine(DateTime.Now);
         Console.WriteLine(DateTime.Now.Date);
         Console.WriteLine(DateTime.Now.Year);

         Console.WriteLine(DateTime.Now.AddDays(4));
         Console.WriteLine(DateTime.Now.AddMonths(1));
         
         //datetimeformat
         Console.WriteLine(DateTime.Now.ToString("DD"));
         Console.WriteLine(DateTime.Now.ToString("MM"));

         //mathlibrary
         Console.WriteLine(Math.Abs(-100));//100
         Console.WriteLine(Math.Sin(45));
         Console.WriteLine(Math.Tan(90));
         Console.WriteLine(Math.Log10(10));
         Console.WriteLine(Math.Pow(3,2));
         






      


    }
  }

}