/* Operators are used to perform operations on variables and values.
    Logical Operators are used to determine the logic between variables or values. 
        && (Logical and): Returns True if both statements are true (e.g., x < 5 && x < 10).
        || (Logical or): Returns True if one of the statements is true (e.g., x < 5 || x < 4).
        ! (Logical not): Reverses the result, returns False if the result is true (e.g., !(x < 5 && x < 10)). 
*/

// 1.
bool isAdult = true;
bool hasID = false;

Console.WriteLine(isAdult && hasID); // false
Console.WriteLine(isAdult || hasID); // true
Console.WriteLine(!isAdult);         // false

// 2. Short-circuit
int x = 0;
bool result = x != 0 && (10 / x > 1);
Console.WriteLine("Result: " + result); // false

// 3. 
int age = 22;
bool hasLicense = true;
bool isStudent = false;

bool canDrive = age > 18 && hasLicense && !isStudent;
Console.WriteLine(canDrive); // true

// 4. Arithmetic + Comparison + Logical
double gpa = 3.6;
int credits = 120;
bool hasDisciplineIssue = false;

bool isEligible = gpa >= 3.5 && credits >= 100 && !hasDisciplineIssue;

Console.WriteLine(isEligible); // true