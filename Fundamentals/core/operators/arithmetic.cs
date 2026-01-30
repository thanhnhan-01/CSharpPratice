/* Operators are used to perform operations on variables and values.
    Arithmetic Operators are used to perform common mathematical operations. 
        + (Addition): Adds together two values (e.g., x + y).
        - (Subtraction): Subtracts one value from another (e.g., x - y).
        * (Multiplication): Multiplies two values (e.g., x * y).
        / (Division): Divides one value by another (e.g., x / y).
        % (Modulus): Returns the remainder of a division (e.g., x % y).
        ++ (Increment): Increases the value of a variable by 1 (e.g., x++).
        -- (Decrement): Decreases the value of a variable by 1 (e.g., x--). 
*/

// 1.
int a = 10;
int b = 3;
Console.WriteLine("a + b = " + (a + b));
Console.WriteLine("a - b = " + (a - b));
Console.WriteLine("a * b = " + (a * b));
Console.WriteLine("a / b = " + (a / b)); // integer division
Console.WriteLine("a % b = " + (a % b)); // remainder

// 2.
double x = 10;
double y = 3;
double result = x / y;
Console.WriteLine("Result: " + result);

// 3. Increment / Decrement
int count = 5;
Console.WriteLine("Count++: " + count++); // postfix increment
Console.WriteLine("Count: " + count);
Console.WriteLine("++Count: " + ++count); // prefix increment
Console.WriteLine("Count--: " + count--); // postfix decrement
Console.WriteLine("Count: " + count);
Console.WriteLine("--Count: " + --count); // prefix decrement