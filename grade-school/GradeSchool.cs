using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public Dictionary<int, List<string>> studentsInGrades = new Dictionary<int, List<string>>();
    
    public void Add(string student, int grade)
    {
       if(studentsInGrades.ContainsKey(grade))
       {
            studentsInGrades[grade].Add(student);
            studentsInGrades[grade].Sort();
       }
       else
       {
            studentsInGrades.Add(grade, new List<string> { student });
       }
    }

    public IEnumerable<string> Roster()
    {  {
        List<string> roster = new List<string>();
        List<int> sortedGrades = new List<int>(studentsInGrades.Keys);
        
        sortedGrades.Sort();
        foreach (int grade in sortedGrades)
        {
            roster.AddRange(studentsInGrades[grade]);
        }
        return roster;
       }
    }

    public IEnumerable<string> Grade(int grade)
    {   
        if(studentsInGrades.ContainsKey(grade))
        { 
            studentsInGrades[grade].Sort();
            return studentsInGrades[grade];
        }
        else
        {
        return new List<string>();
        }
    }
}