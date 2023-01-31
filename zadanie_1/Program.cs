int extentSumm(int a, int b)
{
    if (b < 0)
    return -1;
    int decision = 1;
    int extent = 1;
    while (decision <= b)
    {
        extent = extent * a;
        decision++;
        
    }
    return extent;
}
Console.WriteLine("Введите число A и число B, тогда программа выдаст значение при возведении числа A в степень B.");
Console.Write("Введите число A - ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите число B - ");
int.TryParse(Console.ReadLine(), out int b);
if (extentSumm(a, b) == -1)
{
    Console.WriteLine("Ваше число, в степень которого возводится А не является натуральным.");
}
else
Console.WriteLine(extentSumm(a, b));
