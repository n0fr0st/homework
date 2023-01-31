int summOfDigits(int n)
{
        if(n < 0)
        n = Math.Abs(n);
        int result = 0;
        while (n != 0)
        {
                result = n%10 + result;
                n = n/10;
        }
        return result;
}
Console.WriteLine("Введите число и программа выдаст сумму цифр этого числа.");
int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine(summOfDigits(n));