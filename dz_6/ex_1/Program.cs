/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int counter = 0;

while (true)
{
    System.Console.WriteLine("введите число: ");
    var textNumber = Console.ReadLine();
    if (textNumber == "") break;
    if (Convert.ToInt32(textNumber) > 0) counter++;
}

System.Console.WriteLine(counter);

