/*
    Ternary operator (?:) provides a shorthand way to write simple if...else statements in a single line of code.
    variable = (condition) ? expressionTrue : expressionFalse;
*/

// 1.
int time = 20;
string greeting;

if (time < 18)
{
    greeting = "Good day.";
}
else
{
    greeting = "Good evening.";
}
Console.WriteLine(greeting); // Good evening.

// 2.
int score = 85;

string grade = score >= 50 ? "Pass" : "Fail";

Console.WriteLine(grade);