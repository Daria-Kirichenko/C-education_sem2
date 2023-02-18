// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите любое число (трехзначное):");
if(number > 99 && number < 1000)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine(secondDigit);
}
else Console.WriteLine("Читайте условия внимательнее - число должно быть трехзначным");