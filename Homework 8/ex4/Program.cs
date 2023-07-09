/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateRandomArrayInt(int rows, int columns, int height, int minValue, int maxValue)
{
    
    int[] mass = new int[rows*columns*height];
    int  number;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(minValue,maxValue+1);
        number = mass[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (mass[i] == mass[j])
                {
                    mass[i] = new Random().Next(minValue,maxValue+1);
                    j = 0;
                    number = mass[i];
                }
                number = mass[i];
            }
        }
    }
    
    int c = 0;
    int[,,] array = new int[rows,columns,height];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = mass[c];
                c++;
                System.Console.Write(array[i, j, k]+$"({i},{j},{k}) ");
            }
             System.Console.WriteLine();
        }
       
    }
    System.Console.WriteLine();

    return array;
}

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер высоты");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateRandomArrayInt(rows,columns,height,minValue,maxValue);
