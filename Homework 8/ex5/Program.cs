/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
//код адаптирован только для матрицы 4 на 4. для другой размерности работать не будет

int[,] CreateRandomArrayInt(int rows, int columns)
{
    int[,] array = new int[rows,columns];
    int n = rows;
    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j < columns; j++)
        {
            array[i,j] = 0;
        }
    }
    for(int i = 0; i < rows; i++){

        array[0,i] = i+1;
    }
    for(int i = 1; i < rows; i++){

        array[i,rows-1] = n+1;
        n++;
    }
    for(int i = 1; i < rows; i++){

        array[rows-1,rows-i] = n;
        n++;
    }

    for(int i = 1; i < rows; i++){

        array[rows-i,0] = n;
        n++;
    }
    
    for (int i = 1; i < rows-1; i++){

        array[1,i] = n;
        n++;
    }

    for(int i = 1; i < rows-2; i++){

        array[i+1,rows-2] = n;
        n++;
    }

    for(int i = 1; i < rows-2; i++){
        array[rows-2,rows-3] = n;
        n++;
    }

    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j < columns; j++){
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    
    return array;
}


int rows = 4;
int columns = 4;

CreateRandomArrayInt(rows,columns);