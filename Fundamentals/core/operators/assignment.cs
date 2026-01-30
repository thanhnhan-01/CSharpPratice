/* Operators are used to perform operations on variables and values.
    Assignment Operators are used to assign values to variables. 
        = (Assignment): Assigns the value on the right to the variable on the left (e.g., x = 5).
        += (Addition assignment): Adds a value to a variable and assigns the result (e.g., x += 3 is the same as x = x + 3).
        -= (Subtraction assignment): (e.g., x -= 3 is the same as x = x - 3).
        *= (Multiplication assignment): (e.g., x *= 3 is the same as x = x * 3).
        /= (Division assignment): (e.g., x /= 3 is the same as x = x / 3).
        %= (Modulus assignment): (e.g., x %= 3 is the same as x = x % 3). 
*/

// 1.
int x = 10;
x = 20;
Console.WriteLine("x = " + x); // 20

// 2.
int number = 10;
Console.WriteLine($"Number = {number += 5}"); // number = number + 5 = 15
Console.WriteLine($"Number = {number -= 2}"); // number = number - 2 = 13
Console.WriteLine($"Number = {number *= 3}"); // number = number * 3 = 39
Console.WriteLine($"Number = {number /= 2}"); // number = number / 2 = 19
Console.WriteLine($"Number = {number %= 4}"); // number = number % 4 = 3

// 3. Chaining assignment
int a, b, c;

a = b = c = 100;
Console.WriteLine(a); // 100
Console.WriteLine(b); // 100
Console.WriteLine(c); // 100