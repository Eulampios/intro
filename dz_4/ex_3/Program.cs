/*
Напишите программу, которая задает массив 
из 8 элементов и выводит их на экран.
*/


void printArray(int count = 8)
{
    Random rnd = new Random();
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(1, 256);
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

printArray();
printArray(5);

