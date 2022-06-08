using System;
namespace forloop
{
    class Consructer
    {
       static void Main(string[] args) {
        
        //use player class and create player object
        Player player1 = new Player();
        player1.name="muhammed salah";
        player1.position="wing";
        player1.age=29;
        player1.team="liverpool";
        Console.WriteLine(player1);
       }
    } 
       //creating class
       class Player
      {
         public string name;
         public int age;
         
         public string team;
         public string position;


      }

      /* example field usage
      Class Player
      {
        private string name; //field

        public string Name
        {
            get {return name};
            set {name = value};
        }

        //property example:
        private int age=0;
        public int Age
        {
            get {return age;}
            set {
                if (value>0)
                age = value;
            }
        }
        */


    
     
      

       

}

  