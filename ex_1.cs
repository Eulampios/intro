// /*
// Внутри класса Answer напишите метод CompareNambers, который принимает на вход
// два числа и выводит, какое число больше, какое меньше
// */

// using System;
// public class Answer
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже

//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
//         }
//         else if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"Введенные числа равны {secondNumber}");
//         }

//     }
//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int firstNumber, secondNumber;
//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 10;
//         }
//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }
