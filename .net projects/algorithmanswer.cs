using System;
using System.Linq;
namespace forloop
{
    class answer
{
       static void Main(string[] args) {

        //question 1

          //creating list
          List<int>  primenumbers = new List<int>();
          List<int> notprimenumbers = new List<int>();
          //getting 20 number input 
         for(int i=0; i<20; i++)
         {
             int number=Convert.ToInt32(Console.ReadLine());
             if (number%2 == 0 & number%number == 0)
             {
                primenumbers.Add(number);
             }
             else
             {
                 notprimenumbers.Add(number);
             }
         }
         

        //counting size
        int primetotalCount = primenumbers.Count();
        int notprimecount = notprimenumbers.Count();
        //average number of array
        int sum = 0;
        int notprimesum = 0;
        for(int i=0; i<=primetotalCount; i++)
        {
            sum += primenumbers[i];
        }
        for(int i=0; i<=notprimecount; i++)
        {
            notprimesum += notprimenumbers[i];
        }
        Console.WriteLine($"prime list average:{sum} not prime average: {notprimesum}" );




    }
  }

}