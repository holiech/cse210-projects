using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            char letterGrade;
            string gradeSign = "";

            if (grade >= 90)
            {
                letterGrade = 'A';
                if (grade % 10 >= 7)
                    gradeSign = "+";
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
                if (grade % 10 >= 7)
                    gradeSign = "+";
                else if (grade % 10 < 3)
                    gradeSign = "-";
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
                if (grade % 10 >= 7)
                    gradeSign = "+";
                else if (grade % 10 < 3)
                    gradeSign = "-";
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
                if (grade % 10 >= 7)
                    gradeSign = "+";
                else if (grade % 10 < 3)
                    gradeSign = "-";
            }
            else
            {
                letterGrade = 'F';
            }

            Console.WriteLine($"Your letter grade is: {letterGrade}{gradeSign}");

            if (letterGrade != 'F' && grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else if (letterGrade == 'F')
            {
                Console.WriteLine("Keep working hard, you can do better next time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid grade percentage.");
        }
    }
}