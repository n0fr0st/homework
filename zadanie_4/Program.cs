Console.WriteLine("Введите число,  программа выпишет все четные числа от 1 до вашего числа.");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
    if (i%2 == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}