//Напишите программу, которая принимает на вход целое 
//число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите натуральное число от 10 до 99:");
int a = int.Parse(Console.ReadLine()!);
int b = a / 10;
int c = a % 10;
if (b == c)
{
    Console.WriteLine("Цифры равны.");
}
else
{
    if (10 <= a && a <= 99)
    {
    if (b > c)
    {
        Console.WriteLine(a / 10);
    }
    else
    {
        Console.WriteLine(a % 10);
    }
    }
    else
    {
    Console.WriteLine("Число должно быть двузначным!");
    }
}
