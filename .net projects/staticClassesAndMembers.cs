using System;
namespace forloop
{
    class staticclasses
{
       static void Main(string[] args) {
          // accsessing to static  class member:
          Console.WriteLine("team count is :{0}",teams.teamcounter);
          //accessing to nonstatic classmember:
          teams team1 = new teams();
          team1.teamValue=120000;
          team1.teamNames="man.city";
          
          
      


    }
  }
  class teams
  {
      public static int teamcounter;
      public  string teamNames;
      public  int teamValue;
      public static string league;
      
      public teams()
      {
          teamcounter++;
      }

  }

}