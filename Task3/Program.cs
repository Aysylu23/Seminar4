/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int result = 1;

for(int i = 1; i <= number; i++)
{
    result *= i;
}

Console.WriteLine($"{number} -> {result}");