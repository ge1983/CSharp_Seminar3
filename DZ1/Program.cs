// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Ввелите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 10000 && Number < 100000)
{
    if ((Number / 10000 == Number % 10) && ((Number / 1000) % 10 == (Number / 10) % 10))
    {
        Console.WriteLine("Введенное число являетя полиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не являетя полиндромом");
    }
    
}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}
