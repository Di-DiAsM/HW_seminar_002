// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// 1. Без методов*************************************************
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int n = number;

// while (n > 999)
// {
//     n = n / 10;    
// }
// if (n < 1000 & n > 99)
// {
//     n = n % 10;
//     Console.WriteLine(n);
// }
// else
// {
//    Console.WriteLine("третьей цифры нет"); 
// }

// 2. C методом**************************************************
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int threeDigit(int number)
{
    int result = number %10;
    return result;
}
// **************************************************************
Console.Clear();
int number = ReadInt("Введите трехзначное число: ");
int n = number;

while (number > 999)
{
    number = number / 10;
}
if (number < 1000 & number > 99)
{
    Console.WriteLine(threeDigit(number));
}
else
{
   Console.WriteLine("третьей цифры нет"); 
}


