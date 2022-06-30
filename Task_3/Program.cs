// Задайте двумерный массив. Найдите элементы, 
// у которых номер строки и столбца чётные, и замените эти 
// элементы на их квадраты.

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

void ModifyAray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i+=2)
    {
        for (int j = 1; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
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
    Console.WriteLine();
}

int[,] array = CreateArray();
FillAray(array);
PrintArray(array);
ModifyAray(array);
PrintArray(array);