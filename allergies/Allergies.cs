using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public int _allergyScore;
    public Allergies(int mask)
    {
        _allergyScore = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
      return (_allergyScore & (int) allergen) > 0;
            
    }

    public Allergen[] List()
    {   List<Allergen> _allergyList = new List<Allergen>();
        
        int tempAllergy = _allergyScore;   
        if(tempAllergy == 0){return _allergyList.ToArray(); }
         foreach(Allergen allergy in Enum.GetValues(typeof(Allergen)))
         {
            if(IsAllergicTo(allergy))
            {
                _allergyList.Add(allergy);
                tempAllergy = tempAllergy - (int)allergy;
            }
         }
    return _allergyList.ToArray();
        
    }
}