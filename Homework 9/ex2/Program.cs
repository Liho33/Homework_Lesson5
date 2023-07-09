// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum(int m, int n)
{
    if(m < n)
    {
        return SumNum(m + 1, n) + m;
    }
    else if (m > n)
    {
        return SumNum(m - 1, n) + m;
    } 
    else return m;
}

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumNum(m, n));