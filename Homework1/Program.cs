/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/



Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

double pow = Math.Pow (numberA,numberB);

Console.WriteLine($"{numberA},{numberB} -> {pow}");