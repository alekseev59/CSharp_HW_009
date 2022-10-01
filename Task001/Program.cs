//Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "4, 2"
//N = 8 -> "8, 6, 4, 2"


Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count >= n)
    {
        Console.Write("Введите число больше 2");
        return;
    }
    else
    {
        NaturalToLow(n, count + 2);
        Console.Write(count + " ");
    }
}