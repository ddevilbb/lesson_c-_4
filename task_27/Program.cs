// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");

int InputNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            
            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Допустимое значение: любое число");
        }
    }
}

int SumDigit(int number)
{
    number = Math.Abs(number);
    int result = number % 10;
    while (number > 9)
    {
        number /= 10;
        result += number % 10;
    }

    return result;
}

int number = InputNumber();
Console.WriteLine($"{number} -> {SumDigit(number)}");
