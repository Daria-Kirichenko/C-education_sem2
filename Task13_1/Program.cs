int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число:");
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
}
Console.WriteLine(number % 10);
