using System;
using System.Linq;

public static class Bob
{   
    static bool IsAShout(string phrase) 
      {
        return (phrase.Any(letter => Char.IsLetter(letter)) && phrase.ToUpper() == phrase)
        ? true
        : false;
      }

      static bool IsAQuestion(string phrase) 
      {
        return (phrase.EndsWith("?"))
        ? true
        : false;
      }
      static bool IsAShoutQuestion(string phrase)
      {
        return IsAShout(phrase) && IsAQuestion(phrase)
        ? true
        : false;
      }


    public static string Response(string statement)
    {
        string trimmedStatement = statement.Trim();      
       
        if(String.IsNullOrWhiteSpace(trimmedStatement))
        { 
            return "Fine. Be that way!";
        }
       
       if(IsAShoutQuestion(trimmedStatement))
        {
            return "Calm down, I know what I'm doing!";
        }

        if(IsAShout(trimmedStatement))
        {
            return "Whoa, chill out!";
        }

       if(IsAQuestion(trimmedStatement))
        {
            return "Sure.";
        }

         
        return "Whatever.";

    }
}
