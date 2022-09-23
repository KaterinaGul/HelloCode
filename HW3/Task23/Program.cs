// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number =1;

while (count <= N)
{
    number = count*count*count;
    count++;
    Console.Write($"{number}, ");
}