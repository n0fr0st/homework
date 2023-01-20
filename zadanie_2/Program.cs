//задание №2
Console.WriteLine("Введите 3 числа, и программа покажет какое максимальное.");
Console.WriteLine();
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int max2;
if (num2 > num3)
{
    max2 = num2;
}
else 
{
    max2 = num3;
}
if (max > max2)
{
    Console.WriteLine("Число " + max + " - максимальное.");
}
else
{
    Console.WriteLine("Число " + max2 + " - максимальное.");
}