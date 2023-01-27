// палиндром
Console.WriteLine("Введите 5ти значное число и программа выведет, является ли оно палиндромом.");
Console.WriteLine("Введите ваше число : ");
if(int.TryParse(Console.ReadLine(), out var num))
{
    if (num <= 99999 && num >= 10000)
{
    if ((num / 10000 == num % 10) && (num/1000%10 == num%100/10))
        Console.WriteLine("число является палиндромом");

    else 
        Console.WriteLine("Ваше число не является палиндромом.");
}
else Console.WriteLine("Вы ввели некорректное число.");
}
else Console.WriteLine("Вы ввели не число.");