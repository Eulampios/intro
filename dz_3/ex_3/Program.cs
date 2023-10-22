/*
Внутри класса Answer напишите метод ShowCube, который принимает
на вход число (N) и выводит таблицу кубов чисел от 1 до N 
(включительно) каждое на новой строке
*/


System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result;

for (int i = 1; i < N + 1; i++)
{
    result = i * i * i;
    System.Console.WriteLine(result);
}
