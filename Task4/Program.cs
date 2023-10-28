/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int sizeArray = 8;
Random randomizer = new Random();
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(0, 2);
    Console.Write(numbers[i] + " ");
}
