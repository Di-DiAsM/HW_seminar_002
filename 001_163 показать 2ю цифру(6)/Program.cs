// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1. без методов*********************************************************
// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = (number / 10) % 10;

// if (number > 100 & number < 1000)
// {
//     Console.WriteLine(secondDigit);          
// }
// else
// {
//     Console.WriteLine("Не верный ввод");
// }

// 2. c методом***********************************************************
Console.Clear();
int number = ReadInt("Введите трехзначное число: ");
if (number > 100 & number < 1000)
{
    Console.WriteLine(SecDigitNum(number));         
}
else
{
    Console.WriteLine("Не верный ввод");
}
// ***********************************************************************
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SecDigitNum (int number)
{
    int result = (number / 10) % 10;
    return result;
}