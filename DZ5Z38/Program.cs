// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int length = ReadInt("Array length");

double[] array = GetDRandomArray(length);

Console.WriteLine(PrintDArray(array));

Console.WriteLine($"Разница между максимальным и минимальным элементом массива=: {GetSumMaxMin(array)}");

double GetSumMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }

    return max - min;

}


string PrintDArray(double[] array)
{
    System.Text.StringBuilder sb = new System.Text.StringBuilder (array.Length);
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append($"{array[i]} ");
    } 
    return sb.ToString();
}

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine()!);
}

double [] GetDRandomArray(int length)
{
    Random random = new Random();
    
    double [] array = new double [length];

    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10, 2);
    }
    return array;
}


