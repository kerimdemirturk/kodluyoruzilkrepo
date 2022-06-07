using System;
namespace forloop
{
    class arrayMethods
{
       static void Main(string[] args) {
         int[] numbers={12,34,21,56,32,786,8965,212};

         void arrayMethods()
         {
             Array.Sort(numbers);
             Array.Clear(numbers,2,2);
             Array.IndexOf(numbers,7);
             

         }

         arrayMethods();
      


    }
  }

}