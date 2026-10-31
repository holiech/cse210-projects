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

            int lastDigit =(int) grade % 10;

            if (grade >= 90)
            {
                letterGrade = 'A';
                if (lastDigit < 3 && grade < 100)
                    gradeSign = "-";
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
                if (lastDigit >= 7)
                    gradeSign = "+";
                else if (lastDigit < 3)
                    gradeSign = "-";
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
                if (lastDigit >= 7)
                    gradeSign = "+";
                else if (lastDigit< 3)
                    gradeSign = "-";
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
                if (lastDigit >= 7)
                    gradeSign = "+";
                else if (lastDigit < 3)
                    gradeSign = "-";
            }
            else
            {
                letterGrade = 'F';
            }

            Console.WriteLine($"Your grade is: {letterGrade}{gradeSign}");

            if (letterGrade != 'F' && grade >= 70)
            {
                Console.WriteLine("Congratulations! you passed the course!");
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