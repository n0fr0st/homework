Console.WriteLine("Введите число и програма покажет 3 по счету цифру.");
int num = Convert.ToInt32(Console.ReadLine());
int digit = num;
if (num > 100)
{
    while (digit > 1000)
    {
        digit = digit / 10;
    }
    int result = digit % 10;
    Console.WriteLine(result);
}
else if (num < 100) 
Console.WriteLine("Нет третьей цифры.");