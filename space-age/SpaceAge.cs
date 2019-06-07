using System;

public class SpaceAge
{
    public long Seconds;

    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        return  Math.Round(Seconds / (31557600.0 * 1),2); 
    }

    public double OnMercury()
    {
        return  Math.Round(Seconds / (31557600.0 * 0.2408467), 2); 
    }

    public double OnVenus()
    {
        return  Math.Round(Seconds / (31557600.0 * 0.61519726), 2);    
    }

    public double OnMars()
    {
        return  Math.Round(Seconds / (31557600.0 * 1.8808158), 2);     
    }

    public double OnJupiter()
    {
        return  Math.Round(Seconds / (31557600.0 * 11.862615), 2);     
    }

    public double OnSaturn()
    {
        return  Math.Round(Seconds / (31557600.0 * 29.447498), 2);     
    }

    public double OnUranus()
    {
        return  Math.Round(Seconds / (31557600.0 * 84.016846), 2);     
    }

    public double OnNeptune()
    {
        return  Math.Round(Seconds / (31557600.0 * 164.79132), 2);  
    }
}   