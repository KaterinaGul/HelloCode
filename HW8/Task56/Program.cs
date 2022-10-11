//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов, не равное количеству строк");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

if (m == n)
Console.WriteLine("Вы задали квадратный массив");
else
{

int SumAcross(int[,] matrix, int i)
{
    int sumAcross = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumAcross += matrix[i, j];
    }
    return sumAcross;
}

int minSumAcross = 0;
int sum = SumAcross(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int temp = SumAcross(matrix, i);
    if (sum > temp)
    {
        sum = temp;
        minSumAcross = i;
    }
}
Console.WriteLine($"В строке {minSumAcross + 1} наименьшая сумма всех элементов");
}