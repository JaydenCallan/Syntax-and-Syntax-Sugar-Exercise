﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;

            if (answer < 9) {
                response = $"{answer} is less than nine";
            } else {
                response = $"{answer} greater than or equal to nine";
            }
            Console.WriteLine(response);
        }
    }
}
