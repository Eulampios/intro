/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("введите номер дня недели: ");
int dayOfTheWeek = Convert.ToInt32(System.Console.ReadLine());

if (dayOfTheWeek < 1 || dayOfTheWeek > 7)
{
    System.Console.WriteLine("нет такого дня недели!");
}
else if (dayOfTheWeek < 6)
{
    System.Console.WriteLine("нет");
}
else
{
    System.Console.WriteLine("да");
}

/*
------------------
|   ВАРИАНТ №2   |
------------------
*/

switch (dayOfTheWeek)
{
    case < 1:
    case > 7:
        System.Console.WriteLine("нет такого дня недели!");
        break;

    case < 6:
        System.Console.WriteLine("нет");
        break;

    default:
        System.Console.WriteLine("да");
        break;
}
