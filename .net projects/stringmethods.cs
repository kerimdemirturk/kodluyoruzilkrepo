using System;
namespace forloop
{
    class stringmethods
{
       static void Main(string[] args) {
         string sentence = "ı wil use few string methods to my sentence";
         sentence.ToUpper();
         sentence.ToLower();
         string.Concat(sentence,"addding some words");
         sentence.EndsWith("finished");
         sentence.StartsWith("start with");
         

      


    }
  }

}