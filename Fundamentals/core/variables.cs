/* 1. Variables */

int age = 25;
string name = "Smith";
bool isStudent = true;

Console.WriteLine("Age: " + age);
Console.WriteLine("Name: " + name);
Console.WriteLine("Student: " + isStudent);

// "Var" is statically typed.
// The type is determined at compile time, unlike 'dynamic' which is resolved at runtime.
// The variable's type is inferred by the compiler at compile time

var score = 9.5;     // double
var title = "C#";   // string
var flag = false;   // bool
const double PI = 3.14;

Console.WriteLine("Score: " + score);
Console.WriteLine("Title: " + title);
Console.WriteLine("Flag: " + flag);
Console.WriteLine("PI: " + PI);

/* 2. Data Types */
// 2.1 Values Types: int, double, bool, char, struct (Stack)
int a = 10;
int b = a;

b = 20;

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

// 2.2 Reference Types: Class, String, Array, Object (Heap)
// Array
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;

arr2[0] = 99;

Console.WriteLine("Arr: " + arr1[0]);

// String is Immutable
string str1 = "Hello";
string str2 = str1;

str2 = "World";

Console.WriteLine("Str1: " + str1);
Console.WriteLine("Str2: " + str2);