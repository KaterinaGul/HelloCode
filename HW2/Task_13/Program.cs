Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <100)
Console.WriteLine("В веденном числе нет третьей цифры");
else
while (num >999) 
{
    num = num/10;
}
int a = num % 10;
Console.WriteLine($"Третья цифра введеного числа:{a} ");


