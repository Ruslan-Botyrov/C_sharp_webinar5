// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] RandArray(int lenght)
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-10, 10) + new Random().NextDouble();
    }
    return answer;
}

void PrintArray(double[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + ", ");
    }
    Console.WriteLine();
}

double MinElementArray(double[] array)
{
    double minElement = array[0], minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
            minIndex = i;
        }
    }
    return minElement;
}

double MaxElementArray(double[] array)
{
    double maxElement = array[0], maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
            maxIndex = i;
        }
    }
    return maxElement;
}

double[] arr = RandArray(5);
PrintArray(arr);
double minElArr = MinElementArray(arr);
double maxElArr = MaxElementArray(arr);

Console.WriteLine($"{maxElArr} - {minElArr} = {maxElArr-minElArr}");