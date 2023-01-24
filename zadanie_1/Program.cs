// первое задание на поиск средней цифры трехзначного числа
Console.WriteLine("Введите 3ех значное число, и программа выдаст вам среднюю цифру этого числа.");
int num = Convert.ToInt32(Console.ReadLine());
int digit = 0;
if (num < 1000 && num > 99)
{
    digit = (num / 10) % 10;
    Console.WriteLine("Средняя цифра числа " + num + " - " + digit);
}
else 
{
    Console.WriteLine("Ваше число не явлется 3ех значным.");
    return;
}