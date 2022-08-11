// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = (number / 10) % 10;

//Console.WriteLine(secondDigit);
// с проверкой

if (number > 100 & number < 1000)
{
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Не верный ввод");
}

// метод не писал, т.к. их дольше писать, чем они сокращали бы время, для таких задач