﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int [8];

for (int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}


int[] CreateArray(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(2);
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}

int[] arr = CreateArray(8);
PrintArray(arr);