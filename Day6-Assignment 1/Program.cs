using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nos, scores;
            Console.WriteLine("Enter Number of Students");
            nos = int.Parse(Console.ReadLine());
            int[][] studentScores = new int[nos][];
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Enter Number of Scores for Student {i + 1}");
                scores = int.Parse(Console.ReadLine());
                studentScores[i] = new int[scores];

                for (int j = 0; j < scores; j++)
                {
                    Console.WriteLine($"Enter Mark {j + 1}");
                    studentScores[i][j] = int.Parse(Console.ReadLine());

                }
            }
            int total = 0, count = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine("Score of Student " + (i + 1));
                int totalScore = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {

                    Console.Write(studentScores[i][j] + " ");
                    totalScore += studentScores[i][j];

                }



                total += totalScore;
                count += studentScores[i].Length;


                Console.WriteLine();
                Console.WriteLine("Total Score: " + totalScore);
                int avg = totalScore / studentScores[i].Length;
                Console.WriteLine("Average Marks " + avg);

                Console.WriteLine("****");
            }
            int av = total / count;
            Console.WriteLine("Average of all students " + av);
            Console.ReadKey();
        }
    }
}
       
