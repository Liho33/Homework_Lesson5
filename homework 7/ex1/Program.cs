// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayRandomArray(double [ , ] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
}
void PrintArray(double[ , ] array)
{ 
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write(array [i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Input number of rows: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double [ , ] array = new double[linesVol, columnsVol];
FillArrayRandomArray(array);
PrintArray(array);