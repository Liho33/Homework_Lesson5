﻿/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void OneMass(int[,] array)
{
    int[] array2 = new int[array.GetLength(1)];
    
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int k = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[k] = array[i,j];
            k++;
        }
        for(int n = 0; n < array2.Length; n++){
            for(int j = 0; j < array2.Length; j++)
            {
                if(array2[n] > array2[j])
                {
                    temp = array2[n];
                    array2[n] = array2[j];
                    array2[j] = temp;
                }
            }
        }
        k = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = array2[k];
            k++;
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
   System.Console.WriteLine();
 
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
OneMass(array);
