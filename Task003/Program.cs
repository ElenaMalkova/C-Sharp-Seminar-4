// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
int i = 0;

while (i<=7)
{
    array[i] = new Random().Next(0,10000);
    i++;
}

Console.WriteLine("Array [{0}]",  String.Join (" ", array));