//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void PosNegSum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
        else sumNeg += array[i];
    }
    System.Console.WriteLine($"Sum of positive elements -> {sumPos} -------- Sum of negative elements -> {sumNeg}");
}

System.Console.WriteLine("Enter array size ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, minValue, maxValue);

PrintArray(array);
PosNegSum(array);