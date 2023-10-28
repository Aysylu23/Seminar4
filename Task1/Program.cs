Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int sum = 0;

/*int i = 1;
while(i <= number)
{
    sum += i;
    i++;
}*/
for (int i = 1; i < number; i ++)
{
    sum +=1;
}

Console.WriteLine($"{number} -> {sum}");
