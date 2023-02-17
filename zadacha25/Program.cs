// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Pow(int numberA, int numberB)
{
    int x = 1;


    for (int i = 1; i <= numberB; i++)
    {
        x *= numberA;
    }


    return x;
}

void main()
{
    Console.Clear();
    Console.Write("Введите число A: ");
    int numA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число B: ");
    int numB = int.Parse(Console.ReadLine()!);
    int result = Pow(numA, numB);
    Console.WriteLine(result);
}

main();