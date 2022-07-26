// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits (string number)
{
int summa = 0;
for (int i = 0; i<number.Length; i++)
    {
        int digit = int.Parse(number[i].ToString());
        summa += digit;
    }
    return summa;
}

Console.WriteLine("Введите целое положительное число:");
string number = Console.ReadLine();
Console.WriteLine("Сумма цифр в числе = " + SumOfDigits(number));