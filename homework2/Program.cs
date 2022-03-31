// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 10);
    }
    return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + ", ");
    }
    Console.WriteLine();
}

int[] arr = RandArray(11);
PrintArray(arr);

int sumOddPos = 0;
int i = 1;
while (i<arr.Length)
{
    sumOddPos = sumOddPos + arr[i]; i=i+2;
}
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях = {sumOddPos}");