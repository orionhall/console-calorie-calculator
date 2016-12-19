using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stairsInBuilding = new int[5];

            Console.WriteLine("How much do you weigh in pounds?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            decimal CalPerStep = ((weight / 15) * .05m);

            Console.WriteLine("How many buildings did you walk through?");
            int buildings = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < buildings; i++)
            {
                Console.WriteLine("How many stairs were in building " + (i + 1) + "?");
                int answer = Convert.ToInt32(Console.ReadLine());
                stairsInBuilding[i] = answer;
            }

            //Got to this point before I had to leave for work

            for (int i = 0; i < buildings; i++)
            {
                Console.WriteLine("On building " + (i + 1) + " you burned " + (int)(stairsInBuilding[i] * CalPerStep) + " calories.");
            }

            decimal totalCalories = 0;
            for (int i = 0; i < buildings; i++)
            {
                totalCalories += (stairsInBuilding[i] * CalPerStep);
            }
            Console.WriteLine("The total number of calories you burned was " + (int)totalCalories + ".");

            Console.WriteLine("How many days per week do you do this exercise?");
            decimal daysWeek = Convert.ToDecimal(Console.ReadLine());
            decimal poundsWeek = (totalCalories * daysWeek) / 3500m;

            Console.WriteLine("At this rate, you will lose " + poundsWeek + " pounds per week!");
            Console.ReadLine();
        }
    }
}
