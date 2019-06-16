using System;
using System.Collections.Generic;
public static class RotationalCipher
{   
    
    public static string Rotate(string text, int shiftKey)
    { 
      bool IsCap;
      char letter;
      char tempCap;
      const char lastLetter = 'z';
      const int AlphabetSize = 26;    
      string excludedChars = " @0123456789!'?.,";
      List<char> excludedCharsList = new List<char>(excludedChars);
      char[] textToArray = text.ToCharArray();
     
      if(shiftKey == AlphabetSize) return text;
          
      for (int i = 0; i < textToArray.Length; i++)
      {  
         letter = textToArray[i];
       
         if(!excludedCharsList.Contains(letter))
         {
            IsCap = Char.IsUpper(letter);
            letter = IsCap ? Char.ToLower(letter) : letter; 
           
            letter = (char)(letter + shiftKey);
            if(letter > lastLetter)
            {
              letter = (char)(letter - AlphabetSize);
            }
            letter = IsCap ? Char.ToUpper(letter) : letter;
            textToArray[i] = letter;
         }
      }
      return new string(textToArray);
    }
}