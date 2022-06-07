using System;
namespace overloading
{
    class arrays
 {
       static void Main(string[] args)
    {
        //overloading methods
        void showingonscreen(string a1,string b1)
        {
            Console.WriteLine( a1 + b1);
        }
        void showingonscreen(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        void showingonscreen(int a)
        {
            Console.WriteLine(a);
        }    
    }
  }

}