using System;
using System.Collections;
using System.Collections.Generic;

public static class MatchingBrackets
{   
    public static bool IsPaired(string input)
  { // Hit the last few tests and realized I was going about the wrong way. Too much info.

    
    Stack CurrentOPenBrackets = new Stack();
    
    Dictionary<char, char> Pairs = new Dictionary<char, char>
    {
      {'{','}'},
      {'(',')'},
      {'[',']'},
    }; 

    foreach(var character in input)
    { 
      // looking for the closer
      if(Pairs.ContainsValue(character))
      {

        if(CurrentOPenBrackets.Count <= 0)
        {
          return false;
        }

        char currentOpen = (char)CurrentOPenBrackets.Peek();
        if(character != Pairs[currentOpen])
        {
          return false;
        }
        else{ 
          CurrentOPenBrackets.Pop();
        }         
      }
      if(Pairs.ContainsKey(character))
      {
        CurrentOPenBrackets.Push(character);
    
      }
    
    }

    return CurrentOPenBrackets.Count == 0 
    ? true
    : false
    ;
  }

}
