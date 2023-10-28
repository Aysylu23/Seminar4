/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int sum = 0;
int temp = number;


while (number/10 > 0) 
{
    sum = number % 10 + sum;
    number = number / 10;

    if(number/10 == 0) sum = sum + (number % 10);
}
Console.WriteLine($"{temp} -> {sum}");