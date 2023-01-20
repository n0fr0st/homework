// первое задание
Console.WriteLine("Введите 2 числа, чтобы вяснить какое большее, а какое меньшее.");
Console.WriteLine("Введите первое число.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " максимальное, а число " + num2 + " минимальное");
}
else if (num2 > num1)
{
    Console.WriteLine("Число " + num2 + " максимальное, а число " + num1 + " минимальное");
}