﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial (int num)
{
    int fact = 1;
    for (int i = 1; i<=num; i++)
    {
        checked
        {
            fact *= i ;
        } 
    }
    return fact;
}


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
