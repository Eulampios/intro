/*
Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические методы:

FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.

Аргументы, передаваемые в метод/функцию:

'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:


Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/


double FindMax(double[] array)
{
    double maxNum = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum) maxNum = array[i];
    }

    return maxNum;
}

double FindMin(double[] array)
{
    double minNum = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
    }

    return minNum;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double differenceMaxMin;

    differenceMaxMin = FindMax(array) - FindMin(array);

    return differenceMaxMin;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}


double[] ar = new double[] { 100.2, 102.9, 1505.7, 166.7, 283.5, 76.4, 30.0, 49.9, 15.3 };
System.Console.WriteLine(FindMax(ar));
System.Console.WriteLine(FindMin(ar));
System.Console.WriteLine(CalcDifferenceBetweenMaxMin(ar));
PrintArray(ar);