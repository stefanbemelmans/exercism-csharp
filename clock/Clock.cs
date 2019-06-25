using System;

public class Clock
{   int _H, _M;
    int HoursInDay = 24;
    int MinutesInHour = 60;
    int extraHours = 0;
    public Clock(int hours, int minutes)
    {
        _H = hours;
        _M = minutes;

        ToString();
    }

    public int Hours
    {
        get
        {   
            return convertHours(_H);
        }
    }

    public int Minutes
    {
        get
        {
            return convertMinutes(_M);
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