// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int length = ReadInt("Array length");

int[] array = GetRandomArray(length, -10, 10);
PrintArray(array);
Console.WriteLine();
int sum = SumArray(array);
Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");

int SumArray (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i +1) % 2 != 0)
        sum += array[i];
    
    }
    return sum;
}

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    
}
