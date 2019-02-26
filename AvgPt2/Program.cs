using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgProject
{
    public class Programo
    {
        public static void Main(string[] args)
        {
            Programo ScoringThing = new Programo();
            ScoringThing.ProgramRun();
        }

        public double AvgScore()
        {
            //Number of scores to be graded
            Console.WriteLine("Enter Number of Grades");
            double count = double.Parse(Console.ReadLine());

            //Total Points Possible
            Console.WriteLine("Enter Number of Points Possible");
            double ptsPoss = double.Parse(Console.ReadLine());

            //divid is number of grades
            double divid = count;
            //sum is total of all grade points
            double sum = 0;
            //operator used to store points, send to sum
            double number = 0;


            //Loop for each number of grades
            do
            {
                Console.WriteLine("Enter Score");
                number = double.Parse(Console.ReadLine());
                sum += number;
                count-- ;
                Console.WriteLine("     ");
            }
            while (count > 0);
            //Division Block
            //avgofnum is sum of points / by number of grades
            double avgPts = sum / divid;

            double avgScore = avgPts / ptsPoss * 100;
            Console.WriteLine("Average points are:" + avgPts);
            Console.WriteLine("Average of scores is:" + avgScore + "%");

            Console.ReadKey();
            return avgScore;
        }

        //Check against scores
        public string TestGrade()
        {
            double score = AvgScore();

            if (score >= 90.0)
            { return "A"; }
            if (score >= 80.0)
            { return "B"; }
            if (score >= 70.0)
            { return "C"; }
            if (score >= 60.0)
            { return "D"; }
            else
                return "F";

        }
        public void ProgramRun()
        {
            Console.WriteLine("Letter grade is " + TestGrade());
            Console.ReadKey();
        }


    }

}










