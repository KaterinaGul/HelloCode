// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int A)
  {
    int count = Convert.ToString(A).Length;
    int next = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      next = A - A % 10;
      result = result + (A - next);
      A = A / 10;
    }
   return result;
  }

int sumNumber = SumNumber(A);
Console.WriteLine($"Сумма цифр введенного числа: {sumNumber}");