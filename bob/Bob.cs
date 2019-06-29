using System;

public static class Bob
{
    public static string Response(string statement)
    {
        string res = "Whatever.";

      if(statement.Length==0)
      { 
        res = "Fine. Be that way!";
      }
      string lastChar = statement[statement.Length-1].ToString();
      Console.WriteLine($"{lastChar}");

     if(statement.ToUpper().Equals(statement))
      {
        res = "Whoa, chill out!";
      }
      else if(statement.ToUpper().Equals(statement) && lastChar == "?")
      { 
        res = "Calm down, I know what I'm doing!";
      }
      else if(lastChar== "?")
      {
        res = "Sure.";
      }
  
      return res;
  

    }

}
