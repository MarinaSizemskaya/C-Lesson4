// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
using System;
using static System.Console;
Clear();
Write("Введите число А: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
int result = A;
for(int i=2; i<=B; i++)
{
    result = result*A;
}
WriteLine($"{A} в {B} степени = {result}");