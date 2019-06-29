using System;
using System.Collections.Generic;

public class Clock
{   int _H, _M;
    int HoursInDay = 24;
    int MinutesInHour = 60;
    int MinutesInDay = (24 * 60);
    public Clock(int hours, int minutes)
    {
        _H = TimeReducer(hours,minutes)["hours"];
        _M = TimeReducer(hours,minutes)["minutes"];

        ToString();
    }

    public int Hours
    {
        get
        {
            return _H;
        }
    }

    public int Minutes
    {
        get
        {   
            return _M;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(_H, _M + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
       return new Clock(_H, _M - minutesToSubtract);
    }

    public override string ToString()
    {
      return string.Format("{0:D2}:{1:D2}", Hours, Minutes);
    }

    public int TimePostivizor(int timeToRoll)
    {
      int negativeMinutes = timeToRoll;
      while(negativeMinutes < 0)
      {
        negativeMinutes += MinutesInDay;
      }
      return negativeMinutes;
    }

    public Dictionary<string,int> TimeReducer(int hours, int minutes)
    {
      Dictionary<string,int> Times = new Dictionary<string,int>();
      
      int totalMinutes = ((hours * 60) + minutes);
          if(totalMinutes < 0)
          { 
            totalMinutes = TimePostivizor(totalMinutes); 
          };

      int tempHour = totalMinutes / MinutesInHour;
           if(tempHour >= HoursInDay)
           {
            tempHour = tempHour %  HoursInDay;
           }

      Times.Add("minutes",  totalMinutes % MinutesInHour);
      Times.Add("hours", tempHour);
      
      return Times;
    }

     public override bool Equals(object obj)
       {
         if ((obj == null) || ! this.GetType().Equals(obj.GetType())) 
          {
             return false;
          }
         else {
            Clock clock = (Clock) obj;
            return (Hours == clock.Hours && Minutes == clock.Minutes); 
         }       
     }      
      
   
}   