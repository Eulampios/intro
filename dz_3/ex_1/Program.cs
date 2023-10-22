/*
Внутри класса Answer напишите метод IsPalindrome, который принимает
на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверять, является ли число пятизначным, в противном случае
вывести Число не пятизначное и False в следующей строке.
*/


System.Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    System.Console.WriteLine(false);
    return;
}

if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
    System.Console.WriteLine(true);
}
else
{
    System.Console.WriteLine(false);
}
