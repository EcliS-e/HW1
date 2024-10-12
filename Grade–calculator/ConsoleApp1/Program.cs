// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
/* Grade–calculator IGME: 201
 * Mariana Espinal 10/12/24
 */

//Declare variables and array.
string student = "Mariana";
int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];
Console.WriteLine("welcome "  + student);
Console.WriteLine("Here are your grades");

//Loop over array and print to console
for (int i = 0; i < grades.Length; i++)
{
    int FinalGrade = grades[i];
    Console.WriteLine(FinalGrade);

    if (90 <= FinalGrade && FinalGrade <= 100)
    {
        Console.WriteLine("This grade is an A.");

        //Nested loop.
        if (FinalGrade == 100)
        {
            Console.WriteLine("WOW!A perfect score.");
        }
    }
    else if (80 <= FinalGrade && FinalGrade <= 89)
    {
        Console.WriteLine("This grade is a B.");
    }
    else if (70 <= FinalGrade && FinalGrade <= 79)
    {
        Console.WriteLine("This grade is a C");
    }
    else if (65 <= FinalGrade && FinalGrade <= 69)
    {
        Console.WriteLine("This grade is a D");
    }
    else if (0 <= FinalGrade && FinalGrade <= 64)
    {
        Console.WriteLine("This grade is an F");
    }
    else {
        Console.WriteLine("This is out of the 0–100. How did you even get this grade?");
    }

   

}

//Calculate average and print to console.
int Average = (100 + 92 + 87 + 200 + -20 + 52 + 82 + 75 + 67 + 88) / 10;
Console.WriteLine(Average);

//Finish.
Console.WriteLine("We have a displayed all grades for " + student);