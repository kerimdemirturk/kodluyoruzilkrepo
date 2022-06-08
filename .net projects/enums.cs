using System;
namespace forloop
{
    class enums
   {
       static void Main(string[] args) {
          
       
       string name ="mustafa";
       int wage = 25000 ;

       if(wage <= (int)wages.highwages)
       {
         Console.WriteLine($"{name} living in {lifeStandart.middle} and earning less than {wages.highwages} ");
       }
       


       enum lifeStandart
       {
           low,
           middle,
           high
       }
       enum wages
       {
           highwages = 100000,
           midwages = 50000,
           lowwages = 10000
       }


       

      


     }
    }

}