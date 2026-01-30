/* Operators are used to perform operations on variables and values.
    Comparison Operators are used to compare two values and return a bool value (true or false). 
        == (Equal to): Returns true if both values are equal (e.g., x == y).
        != (Not equal to): Returns true if values are not equal (e.g., x != y).
        > (Greater than): Returns true if the first value is greater than the second (e.g., x > y).
        < (Less than): Returns true if the first value is less than the second (e.g., x < y).
        >= (Greater than or equal to): Returns true if the first value is greater than or equal to the second (e.g., x >= y).
        <= (Less than or equal to): Returns true if the first value is less than or equal to the second (e.g., x <= y). 
*/

// 1.
int a = 10;
int b = 20;
Console.WriteLine(a == b); // false
Console.WriteLine(a != b); // true
Console.WriteLine(a > b);  // false
Console.WriteLine(a < b);  // true
Console.WriteLine(a >= b); // false
Console.WriteLine(a <= b); // true

// 2. String
string s1 = "hello";
string s2 = "hello";
string s3 = "Hello";

Console.WriteLine(s1 == s2); // true
Console.WriteLine(s1 == s3); // false (case-sensitive)

// 3. CompareTo
int result = "apple".CompareTo("banana");

Console.WriteLine($"Result: {result}");
// < 0 → smaller
// = 0 → equal
// > 0 → greater