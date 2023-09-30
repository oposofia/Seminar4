// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = Sum(number);
Console.WriteLine($"Суума цифр числа = {sumDigit}");

int Sum (int num)
{
    int sum = 0;
    int length = 0;
    int number1 = num;
    while (number1 !=0)
    {
        number1 /= 10;
        length ++;
    }
    int[] array = new int[length];
    for (int i = 0; i<length;i++)
    {
        array[i]=num%10;
        num/=10;
        sum += array[i];
    }
    return sum;
}
