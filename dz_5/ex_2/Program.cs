/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.

Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Аргументы, передаваемые в метод/функцию:


'18, 76, 11'
На выходе:


18      76      11  
Сумма нечетных элементов: 76
*/

int SumOddElements(int[] array)
{
    int sumElements = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sumElements += array[i];
    }


    return sumElements;
}


int[] ar = new int[] { 1, 2, 3, 4, 5 };
System.Console.WriteLine(SumOddElements(ar));


//=============================================================

void PrintArray(int[] array)
{
    System.Console.WriteLine("{0}", string.Join("\t", array));
    System.Console.WriteLine($"Сумма нечетных элементов: {SumOddElements(array)}");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     System.Console.Write(array[i] + "\t");
    // }
    // System.Console.WriteLine();
}


PrintArray(ar);

