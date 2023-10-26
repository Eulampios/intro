/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.

Аргументы, передаваемые в метод/функцию:

'124, 378, 593, 821, 456'
На выходе:


Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/


int CountEvenElements(int[]? array = null)
{
    if (array == null)
    {
        array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
    }
    else
    {
        foreach (int item in array)
        {
            if (item < 100 || item > 999)
            {
                return -1;
            }
        }
    }

    int countEvenNums = 0;

    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            countEvenNums++;
        }
    }
    return countEvenNums;
}


int[] ar = new int[] { 152, 144, 310, 112 };
System.Console.WriteLine(CountEvenElements());

//=============================================================

void PrintArray(int[] array)
{
    System.Console.WriteLine("{0}", string.Join("\t", array));
    System.Console.WriteLine($"Количество четных элементов: {CountEvenElements(array)}");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     System.Console.Write(array[i] + "\t");
    // }
    // System.Console.WriteLine();
}


PrintArray(ar);


