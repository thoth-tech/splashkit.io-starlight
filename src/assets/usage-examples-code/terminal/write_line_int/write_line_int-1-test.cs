using System;

// Let's do writeLine examples with different numbers

Console.WriteLine(5);
Console.WriteLine(10);
Console.WriteLine(15);
Console.WriteLine(67890);

int a = 300 - 123;
int b = 20 * 8;
int c = 500 / 25;

Console.WriteLine(a);  
Console.WriteLine(b);  
Console.WriteLine(c);  

// Let's print large integer
int largeInt = int.MaxValue;
Console.WriteLine(largeInt);  

// Let's print large negative integers
int negativeInt = -9876;
Console.WriteLine(negativeInt);  

// Let's do String-Integer Mismatch
string str = "3";
int num = 5;

int convertedStr = int.Parse(str);
Console.WriteLine(convertedStr + num);  // This will correctly output 8
