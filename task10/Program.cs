﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int a1 = n / 10;
int a2 = a1 % 10;
if ( n > 99 & n < 1000)
    Console.WriteLine($"Вторая цифра числа {n} -> {a2}");
else
    Console.WriteLine($"Введено некорректное значение");