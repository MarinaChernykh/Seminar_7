// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.


int[,] CreateArray()
{
    Console.Write("Введите кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}

void FillAray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void SumDiagonal(int[,] array)
{
    int sum = 0;
    int length = 0;
    if (array.GetLength(0) < array.GetLength(1)) length = array.GetLength(0);
    else length = array.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (i == j) sum += array[i, j];
    //     }
    // }
    Console.WriteLine ($"Сумма эл-в диагонали = {sum}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray();
FillAray(array);
PrintArray(array);
SumDiagonal(array);