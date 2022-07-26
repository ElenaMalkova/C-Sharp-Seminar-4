// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите положительное целое число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите положительное целое число B");
int b = int.Parse(Console.ReadLine());
int result = 1;

for (int count = 1; count <= b; count++)
{
    result = result * a;
}
Console.WriteLine("Число {0} в степени {1} = {2}", a, b, result);