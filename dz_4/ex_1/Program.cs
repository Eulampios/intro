/*
Напиишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В.
*/

int degreeOfNumber(int num, int deg)
{
    int result = num;

    for (int i = 1; i < deg; i++)
    {
        result *= num;
    }

    return result;
}

System.Console.WriteLine(degreeOfNumber(3, 4));
