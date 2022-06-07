using System;
namespace forloop
{
    class Program
{
       static void Main(string[] args) {
         for(int a=0; a<10; a++)
         {
             Console.WriteLine(a);
         }
         for (int i = 1; i <= 10; i++)
         {
            if (i % 2 == 0)
               continue;
                Console.WriteLine(i);
         }
      


    }
  }

}