﻿/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/


Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int tempNumber = number;
int digitCount = 0;

while(tempNumber > 0)
{
    digitCount++;
    tempNumber /= 10;
}

Console.WriteLine($"{number} -> {digitCount}");