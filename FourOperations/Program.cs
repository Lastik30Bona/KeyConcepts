﻿double firstNumber = double.Parse(Console.ReadLine());  
double secondNumber  = double.Parse(Console.ReadLine());

double sum = firstNumber + secondNumber;    

double diff = firstNumber - secondNumber;

double result = firstNumber * secondNumber;

double division = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {diff:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {result:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {division:F2}");

 