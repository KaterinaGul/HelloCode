Console.WriteLine("Введите число от 1 до 7, соответствующее дню недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num >1 && num <6)
Console.WriteLine("Это не выходной");

else if (num ==6 || num ==7)
Console.WriteLine("Это выходной");

else
Console.WriteLine("Введено неверное число");