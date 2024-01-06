//Напишите программу, которая на вход принимает 
//натуральное число N, а на выходе показывает его цифры через запятую.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число N:");
        int N = int.Parse(Console.ReadLine()!);
        while (N > 0)
        {
        Console.WriteLine(N % 10);
        N = N / 10; 
        }   
    }
}