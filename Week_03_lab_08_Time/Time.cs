using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_Time
{
    public class Time
    {
        //Properties
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12; //initializes to TimeFormat.Hour12 at declaration
        private int Hour { get; } //representing hour value
        private int Minute { get; }  //representing Minute value

        //constructor with default values of 0
        public Time(int hours = 0, int minutes = 0)
        {
            Hour = (hours >= 0 && hours <= 24) ? hours : 0; //checks if the first argument is between 0 and 24 and it assigns it to the Hour property, otherwise the value is 0
            Minute = (minutes >= 0 && minutes <= 60) ? minutes : 0; //checks if the second argument is between 0 and 60 and it assigns it to the Minute property, otherwise the value is 0
        }

        //methods
        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:d2}{Minute:d2}"; //using d2 format specifier to get the leading zero. as example, returns 1805
                case TimeFormat.Hour24:
                    return $"{Hour:d2}:{Minute:d2}"; //as example, returns 18:05
                case TimeFormat.Hour12:
                    return $"{Hour % 12:d2}:{Minute:d2}{(Hour < 12 ? " AM" : " PM")}"; //returns the remainder of dividing the Hour field by 12, then sets AM and PM. as example, returns 06:05 PM
                default:
                    return "";
            }
        }
        //takes TimeFormat argument and assigns it to the static TIME_FORMAT field
        public static void SetTimeFormat(TimeFormat time_format) 
        { 
        TIME_FORMAT = time_format;
        }
    }
}
