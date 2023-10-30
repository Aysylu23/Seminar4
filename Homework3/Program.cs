/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/




int array = 8;
Random randomizer = new Random();
int[] numbers = new int[array];
int minNumber = 0;
int maxNumber = 99;

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minNumber, maxNumber +1); 
  
}
Console.Write("[");
for(int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]},");
}
Console.Write("]");