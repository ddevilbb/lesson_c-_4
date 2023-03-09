// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Программа, которая задаёт массив из 8 элементов и выводит их на экран.");

string[] InputStrings()
{
    Console.Write("Введите 8 элементов массива через пробел: ");
    string[] strings = Console.ReadLine()?.Split(" ").Take(8).ToArray()!;

    return strings;
}

string ArrayToString(string[] strings)
{
    string result = "";
    for (int i = 0; i < strings.Length; i++)
    {
        result += (i > 0 ? ", " : "") + strings[i];
    }

    return result;
}

string[] array = InputStrings();
string arrayToString = ArrayToString(array);
Console.WriteLine($"{arrayToString} -> [{arrayToString}]");


// Console.ReadLine()?.Split(' ').Take(3).Select(double.Parse).ToArray()!;
