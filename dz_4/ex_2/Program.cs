/*
Напишите программу, которая принимает на вход 
число и выдает сумму цифр в числе.
*/


int sumOfDigits(int number)
{
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}


System.Console.WriteLine(sumOfDigits(123));

