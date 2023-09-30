// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int b = Convert.ToInt32(Console.ReadLine());

double exponenta = Exponenta(a, b);

Console.WriteLine($"{a} в степени {b} = {exponenta}");

double Exponenta (int number, int degree)
{
    double exp = 1;
    for (int i = 1; i<=degree;i++)
    {
        exp *= number; 
    }
    return exp;
}