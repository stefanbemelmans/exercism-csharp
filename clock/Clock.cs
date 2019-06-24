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
        throw new NotImplementedException("You need to implement this function.");
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString()
    {
      return string.Format("{0:D2}:{1:D2}", Hours + extraHours, Minutes);
    }

    public int convertMinutes(int min)
    {
        if(min == MinutesInHour)
        {   
            extraHours =+ 1;
            return 0;
        };
        
        int totalMins = min;
        if(totalMins > MinutesInHour)
        {
            extraHours =  totalMins / MinutesInHour;
            if(extraHours > HoursInDay)
            {
              extraHours = extraHours % HoursInDay;
            };
            totalMins = totalMins % MinutesInHour; 
            return totalMins;
        }
        return min;
    }
    public int convertHours(int hrs)
    {   
      
        if(hrs == HoursInDay){return 0;};
        if(hrs < 0){return HoursInDay + hrs;};
        int totalHours = hrs;
        while(totalHours > HoursInDay)
        {
            totalHours = totalHours % HoursInDay;   
            convertHours(totalHours);
        }
        return (totalHours);
    }

}   