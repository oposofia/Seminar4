﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit (number);
Console.WriteLine($"Количество цифр в заданном числе {countDigit}");

int CountDigit (int num)
{
    int count = 1;
    while (num>9)
    {
        num = num / 10;
        count++;
    }
    return count;
}




int CountDigit(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigit(number);
Console.WriteLine($"Колличество цифр в числе {result}");