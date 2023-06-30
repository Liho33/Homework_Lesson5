//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Double[] FindArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    return numbers;
}

Double FindMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Maximal element {max}, minimal element {min}");
    return max - min;
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}
Console.WriteLine("Enter array size  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FindArray(numbers);
Console.WriteLine("array is: ");
PrintArray(numbers);
System.Console.WriteLine($"the difference between maximal and minimal elements -> {FindMinMax(numbers)}");