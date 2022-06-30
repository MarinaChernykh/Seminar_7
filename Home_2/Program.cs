// Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве (строка и столбец), 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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

void CheckAray(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());

    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine ("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine ($"Число на заданной позиции = {array[(n-1),(m-1)]}");
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
}

int[,] array = CreateArray();
FillAray(array);
PrintArray(array);
CheckAray (array);



// Если нужно было бы искать в массиве число:

// void NumberFinder(int[,] array)
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     bool numberFinded = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array [i,j] == number)
//             {
//                 Console.WriteLine ("Число найдено");
//                 numberFinded = true;
//                 break;
//             }
//         }
//     }
//     if (numberFinded == false)
//     {
//     Console.WriteLine ("Число не найдено");
//     }
// }