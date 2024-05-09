using System;

namespace Flag_Enums
{
    class Program
    {
        [Flags]
        public enum WeekDays
        {
            None =             0b_0000_0000,
            Saturday =         0b_0000_0001,
            Sunday =           0b_0000_0010,
            Monday =           0b_0000_0100,
            Tuesday =          0b_0000_1000,
            Wednesday =        0b_0001_0000,
            Thursday =         0b_0010_0000,
            Friday =           0b_0100_0000
        }
        static void Main(string[] args)
        {
            WeekDays w1 = WeekDays.Saturday | WeekDays.Sunday | WeekDays.Monday | WeekDays.Tuesday;
            WeekDays w2 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday;

            Console.WriteLine(w1^w2);
            //Console.WriteLine(w2);
        }
    }
}
