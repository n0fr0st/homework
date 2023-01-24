Console.WriteLine("Введите цифру и программа выдаст является ли этот день - выходным.");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day <= 7)
{
    if (day == 6 || day == 7)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}
else
    Console.WriteLine("Ваша цифра не соответствует ни одному дню недели.");

