using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    { 
        char letter;
      char tempCap;
      char[] textToArray = text.ToCharArray();
      
      if(shiftKey == 26) return text;
          
      for (int i = 0; i < textToArray.Length; i++)
      {
        if(Char.IsUpper(textToArray[i]))
        {
          Console.WriteLine(textToArray[i]);
          tempCap = Char.ToLower(textToArray[i]);
          tempCap = (char)(tempCap + shiftKey);
          Console.WriteLine(tempCap);
         if(tempCap > 'z')
            {
              tempCap = (char)(tempCap - 26);
              Console.WriteLine(tempCap);
            }
          else 
            {
              tempCap = (char)(tempCap + 26);
            }
          Console.WriteLine(Char.ToUpper(tempCap));
        }
        else
        {
          letter = textToArray[i];
          letter = (char)(letter + shiftKey);
          
          if(letter > 'z')
            {
              letter = (char)(letter - 26);
            }
          else
            {
              letter = (char)(letter + 26);
            }
          textToArray[i] = letter;
        }
      };
        return new string(textToArray);
    }
}