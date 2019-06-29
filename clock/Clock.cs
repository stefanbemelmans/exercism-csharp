using System;
using System.Collections.Generic;

public class Clock
{   int _H, _M;
    int HoursInDay = 24;
    int MinutesInHour = 60;
    int extraHours = 0;
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
        {   return _H;
           // return convertHours(_H);
        }
    }

    public int Minutes
    {
        get
        {   
            return _M;
            // return convertMinutes(_M);
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

    public int TimePostivizor(int negTimeAmt, int timeToAdd)
    {
      int negativeTime = negTimeAmt;
      while(negativeTime < 0)
      {
        negativeTime += timeToAdd;
      }
      return negativeTime;
    }

    public Dictionary<string,int> TimeReducer(int hours, int minutes)
    {
      Dictionary<string,int> Times = new Dictionary<string,int>();
      
        int totalMinutes = ((hours * 60) + minutes);
      //int totalMinutes = ((hours * 60) + minutes) % MinutesInDay;
      if(totalMinutes < 0)
      { 
        totalMinutes = TimePostivizor(totalMinutes, MinutesInDay);; 
      };

      int tempHour = totalMinutes / MinutesInHour;
      if(tempHour > HoursInDay)
      {
        tempHour = tempHour % HoursInDay;
      }

      Times.Add("minutes",  totalMinutes % MinutesInHour);
      Times.Add("hours", tempHour);
      
      return Times;
    }

    public int convertMinutes(int min)
    {
        if(min == MinutesInHour)
        {   
            _H ++;
            return 0;
        };
        
        int totalMins = min;
         if(totalMins < 0)
        { 
            while(totalMins < 0)
            {  
              totalMins += MinutesInHour;
              _H --;
            }
            return totalMins;
        };
       
        if(totalMins > MinutesInHour)
        {    extraHours = totalMins / MinutesInHour;
            _H = _H + extraHours;
            totalMins = totalMins % MinutesInHour; 
            return totalMins;
        }
       
        return min;
    }
    public int convertHours(int hrs)
    {   
      
        if(hrs == HoursInDay){return 0;};
        int totalHours = hrs;
        if(totalHours < 0)
        { 
            while(totalHours < 0)
            {  
              totalHours += HoursInDay;
            }
            return totalHours;
        };

        while(totalHours > HoursInDay)
        {
            totalHours = totalHours % HoursInDay;   
            convertHours(totalHours);
        }
        return (totalHours);
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