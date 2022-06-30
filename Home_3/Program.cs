// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое 
// элементов в каждом столбце.

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

void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average = Math.Round((sum / array.GetLength(0)),1);
        Console.Write($"{average}  ");
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateArray();
FillAray(array);
PrintArray(array);
Average(array);