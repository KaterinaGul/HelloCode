// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);// [1,10)
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите индекс элемента по строке");
int across = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента по столбцу");
int down = Convert.ToInt32(Console.ReadLine());
if (across > m || down > n)
    Console.WriteLine("Числа с такими координатами нет");
else
{
    object find = matrix.GetValue(across, down);
    Console.WriteLine($"Значение элемента с указанными координатами: {find}");
}
