﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Ввелите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=N; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}