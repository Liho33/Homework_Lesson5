/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateRandomArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return array;
}

int[] SumRows(int[,] array)
{
    int [] sum = new int[array.GetLength(0)];
    int sumRow = 0;
    int pos = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[j] = array[j,i] + sum[j]; 
        }
    }
    for(int i = 1; i < sum.Length;i++)
    {
        sumRow = sum[0];
        if(sumRow > sum[i])
        {
            sumRow = sum[i];
            pos = i;
        }
    }
    Console.WriteLine($"Минимальная сумма в строке {pos+1}");
    return sum;
}

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArrayInt(rows,columns,minValue,maxValue);
SumRows(array);

