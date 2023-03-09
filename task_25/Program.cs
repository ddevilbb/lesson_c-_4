// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход два числа (A и B) " +
                  "и возводит число A в натуральную степень B.");

int InputNumber(string name, bool isNatural = false)
{
    while (true)
    {
        try
        {
            Console.Write($"Введите число {name}: ");
            int number = int.Parse(Console.ReadLine()!);
            if (isNatural && number < 1)
            {
                throw new Exception();
            }

            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Допустимое значение: любое{(isNatural ? " натуральное " : " ")}число");
        }
    }
}


int Pow(int number, int power)
{
    int result = number;
    for (int i = 2; i <= power; i++)
    {
        result *= number;
    }

    return result;
}

int a = InputNumber("A");
int b = InputNumber("B", true);
Console.WriteLine($"{a}, {b} -> {Pow(a, b)}");
