int Qube (int num)
{
    if(num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            int dig =(int)(Math.Pow(i, 3));
            Console.Write(dig + " ");
        }
    }
    else
    Console.WriteLine("число не положительное.");
    return num;
}

Console.WriteLine("Введите число и программа выдаст таблицу кубов от 1 до вашего числа.");
int num = Convert.ToInt32(Console.ReadLine());
Qube(num);