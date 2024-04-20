using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_Time
{
    //enum class outside Time.cs
    public enum TimeFormat
        {
        Mil,
        Hour12,
        Hour24    
    }
    internal class Program
    {
       //given code from the lab
        static void Main(string[] args)
    {
        //create a list to store the objects
        List<Time> times = new List<Time>()
        {
            new Time(9, 35),
            new Time(18, 5),
            new Time(20, 500),
            new Time(10),
            new Time()
        };

        //display all the objects
        TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"\n\nTime format is {format}");
            foreach (Time t in times)
            { 
            Console.WriteLine(t);
            }

        //change the format of the output
        format = TimeFormat.Mil;
        Console.WriteLine($"\n\nSetting time format to {format}");
        Time.SetTimeFormat(format);
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }
        //change the format of the output
        format = TimeFormat.Hour24;
        Console.WriteLine($"\n\nSetting time format to {format}");
        Time.SetTimeFormat(format);
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }
        Console.ReadKey();
    }
    }
}

