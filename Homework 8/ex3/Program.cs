/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] SumRows(int[,] arrayMatrix1, int[,] arrayMatrix2)
{
    int [,] matrixPr = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];
    for (int i = 0; i < matrixPr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixPr.GetLength(1); j++)
        {
            for (int k = 0; k < arrayMatrix2.GetLength(0); k++)
            {
                matrixPr[i,j] += arrayMatrix1[i,k]*arrayMatrix2[k,j];
            }
            System.Console.Write(matrixPr[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return matrixPr;
}

Console.WriteLine("Введите размер cтроки матрицы 1");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца матрицы 1");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон матрицы 1");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон матрицы 1");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер cтроки матрицы 2");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца матрицы 2");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон матрицы 2");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон матрицы 2");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

if (columns1 == rows2)
{
    int[,] arrayMatrix1 = CreateRandomArrayInt(rows1,columns1,minValue1,maxValue1);
    int[,] arrayMatrix2 = CreateRandomArrayInt(rows2,columns2,minValue2,maxValue2);

    SumRows(arrayMatrix1,arrayMatrix2);
}
else{
    Console.WriteLine("Нельзя перемножить матрицы, т.к. число столбцов первой матрицы не совпадает с количеством строк второй матрицы");
}
