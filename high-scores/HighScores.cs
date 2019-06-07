using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> List;

    public HighScores(List<int> list)
    {
        List = list;
    }

    public List<int> Scores()
    {
        return List;
    }

    public int Latest()
    {
       return List.LastOrDefault();
    }

    public int PersonalBest()
    {
       return List.Max();
    }

    public List<int> PersonalTopThree()
    {
        return List.OrderByDescending(i => i).Take(3).ToList(); 
    }
}