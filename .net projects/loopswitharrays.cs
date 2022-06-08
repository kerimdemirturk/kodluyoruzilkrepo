using System;
namespace forloop
{
    class arrayloops
{
       static void Main(string[] args) {
        //array
        int[] teamRank = {21,12,3,2,7,9,11,67};
        string[] teamNames = new string[5];

        //adding values to array:
        teamNames[1]="besiktas";
        teamNames[2]="liverpool";
        
        //loops
        foreach(string teams in teamNames )
        {
            Console.WriteLine(teams);
        }
        
      


    }
  }

}