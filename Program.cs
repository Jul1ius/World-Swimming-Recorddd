using System;

namespace World_Swimming_Record2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeNeededForOneMeterSwimming = double.Parse(Console.ReadLine());

            double secondsForWholeDistance = distance * timeNeededForOneMeterSwimming;
            double timeSlowDown = Math.Floor(distance / 15);
            secondsForWholeDistance += timeSlowDown * 12.5;
            if (secondsForWholeDistance < currentRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {secondsForWholeDistance:f2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was {secondsForWholeDistance - currentRecord:f2} seconds slower.");

            }

        }
    }
}
