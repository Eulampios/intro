/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который 
принимает на вход координаты двух точек pointA и pointB в виде массива 
целых чисел и возвращает растояние между ними в 3D пространстве.
*/


// функция считает квадрат разности
int diffSqrt(int firstNum, int secondNum)
{
    return (firstNum - secondNum) * (firstNum - secondNum);
}

//
int[] pointA = new int[3];
int[] pointB = new int[3];
double distAtoB = 0;

for (int i = 1; i < 4; i++)
{
    System.Console.WriteLine($"введите координату {i} точки А");
    int tempA = Convert.ToInt32(Console.ReadLine());
    pointA[i - 1] = tempA;

    System.Console.WriteLine($"введите координату {i} точки В");
    int tempB = Convert.ToInt32(Console.ReadLine());
    pointB[i - 1] = tempB;
}

distAtoB = Math.Sqrt(diffSqrt(pointA[0], pointB[0]) + diffSqrt(pointA[1], pointB[1]) + diffSqrt(pointA[2], pointB[2]));

System.Console.WriteLine(Math.Round(distAtoB, 2));

