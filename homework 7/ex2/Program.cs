// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine(" введите номер  строки...");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" ввести номер  столбца...");
int column = Convert.ToInt32(Console.ReadLine());
int  [ , ] array = new int [10,10];       
FillArrayRandomArray(array);                                 
PrintArray(array);     
if(line>array.GetLength(0)|| column>array.GetLength(1))
{ 
    System.Console.WriteLine(" такого элемента НЕТ...");
}
else {
    System.Console.WriteLine($" значение элемента строки и столбца { line} , {column} равно {array[line-1, column-1]}");
}
void FillArrayRandomArray(int [ , ] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100,100)/10;
        }
    }
}
void PrintArray(int[ , ] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write(array [i,j] + ". ");
        }
        System.Console.WriteLine();
    }
}