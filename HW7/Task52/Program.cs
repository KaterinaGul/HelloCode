// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
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

int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

double[] average = new double [4];
for (int j = 0, k = 0; j < 4; j++)
{
    double sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += matrix[i, j];
    }
    average[k] = sum / 3;
    Console.Write($"{average[k]}, ");
    k++;
}
