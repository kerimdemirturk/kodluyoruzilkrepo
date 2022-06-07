using System;
namespace ifelse
{
    class Program
{
      static void Main(string[] args) {
      //if else basic 
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      if (a>b)
      {
          Console.WriteLine("a is bigger than b");
      }
      else if(a == b)
      {
          Console.WriteLine("a and b are equal");
      }
      else if(b>a)
      {
          Console.WriteLine("B is bigger than a");
      }
      


    }
  }

}
