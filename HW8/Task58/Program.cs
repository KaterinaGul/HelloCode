// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);// [1,10)
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
//для перемножения двух матриц количество столбцов первой матрицы должно быть равно 
// количеству строк второй матрицы

Console.WriteLine("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы, равное количеству строк второй");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк первой матрицы");
int t = Convert.ToInt32(Console.ReadLine());

int[,] matrixOne = new int[m, n];
int[,] matrixTwo = new int[n, t];

FillArray(matrixOne);
PrintArray(matrixOne);
Console.WriteLine();
FillArray(matrixTwo);
PrintArray(matrixTwo);
Console.WriteLine();

int[,] matrixMultiply = new int[m, t];
//В конечной матрице строки по матрице А, и столбцы по матрице В.

for (int i = 0; i < matrixMultiply.GetLength(0) ; i++)
{
    for (int j = 0; j < matrixMultiply.GetLength(1) ; j++)
    {
        int sum = 0;
        for (int k = 0; k < matrixOne.GetLength(1); k++)
        {
            sum += matrixOne[i, k] * matrixTwo[k, j];
        }
        matrixMultiply[i, j] = sum;
    }
}
Console.WriteLine("Результат перемножения двух матриц: ");
PrintArray(matrixMultiply);