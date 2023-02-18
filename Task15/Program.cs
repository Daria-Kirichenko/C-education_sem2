// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число:");
if(number >= 1 && number <= 5)
{
    Console.WriteLine("Нет, это будний день((");
}
else if(number == 6 || number == 7)
{
    Console.WriteLine("Да, это выходной");
}
else Console.WriteLine("Такого дня недели не существует");