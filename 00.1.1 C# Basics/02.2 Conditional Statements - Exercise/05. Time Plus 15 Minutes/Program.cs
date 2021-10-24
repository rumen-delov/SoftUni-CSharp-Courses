using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the time
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 15;

            int newMinute = minute % 60;
            
            if (minute/60 == 1)
            {
                hour += 1;
                if (hour > 23)
                {
                    hour = hour % 24;
                }
            }

            if (newMinute < 10)
            {
                Console.WriteLine($"{hour}:0{newMinute}");
            }
            else
            {
                Console.WriteLine($"{hour}:{newMinute}");
            }
        }
    }
}
