// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Summ(string[] args)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);

    int sum = 0;
    int temp = 0;

    while (number > 0)
    {
        temp = number % 10;
        sum += temp;
        number /= 10;
    }
    Console.WriteLine(sum);
}

Summ(args);