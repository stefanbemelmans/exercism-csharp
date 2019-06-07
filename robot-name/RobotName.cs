using System;
using System.Collections.Generic;
public class Robot
{
    public Random rando = new Random();
    public HashSet<string> UsedNames = new HashSet<string>();
    public string _Name;
    public string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
   
    public Robot()
        {
            _Name = MakeNewName(); 
        }
    
    public string Name
        {
            get
            {
               return _Name;
            }
        }
    public void Reset()
    {   
        _Name = MakeNewName();
    }

    public string MakeNewName()
        {
            string firstLetter = Letters[rando.Next(0, 25)].ToString();
            string secondLetter = Letters[rando.Next(0, 25)].ToString();
            string randomNumber1 = rando.Next(0,10).ToString();
            string randomNumber2 = rando.Next(0,10).ToString();
            string randomNumber3 = rando.Next(0,10).ToString();
            string newName = firstLetter + secondLetter + randomNumber1 + randomNumber2 + randomNumber3;
            if(UsedNames.Contains(newName))
            {
                newName = MakeNewName();
            }
            UsedNames.Add(newName);
            return newName;
    }
}

