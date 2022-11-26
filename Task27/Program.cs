// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
using System;
using static System.Console;
Clear();
Write("Введите число А: ");

string str = Console.ReadLine();
int summa = 0;
for (int i = 0; i < str.Length; i++)
{
    int currentNumber = int.Parse(str[i].ToString());
    summa+=currentNumber;
}
Console.WriteLine($"Сумма цифр в числе {str} равна {summa}");