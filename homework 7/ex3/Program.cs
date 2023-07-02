//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine(" введите количество строк...");
int linesVol = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" ввести количество столбцов...");
int columnsVol = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [ , ] array = new int [linesVol, columnsVol];
FillArrayRandomArray(array);
PrintArray(array); 
for(int j =0; j<array.GetLength(1); j++) 
{
    int mean = 0;
    for(int i =0; i<array.GetLength(0); i++) 
    {
        mean = (mean + array[i,j]);
    }
    mean = mean/columnsVol;
    System.Console.Write(mean + ";");
}
System.Console.WriteLine();
void FillArrayRandomArray(int[ , ] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[ , ] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write(array [i,j]+", ");
        }
        System.Console.WriteLine();
    }
}