Console.WriteLine("Введите цифру и программа выдаст какому дню недели она соответствует и является ли этот день - выходным.");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:
        Console.WriteLine(day + " - Понедельник - не выходной");
        break;
    case 2:
        Console.WriteLine(day + " - Вторник - не выходной");
        break;
    case 3:
        Console.WriteLine(day + " - Среда - не выходной");
        break;
    case 4:
        Console.WriteLine(day + " - Четверг - не выходной");
        break;
    case 5:
        Console.WriteLine(day + " - Пятница - не выходной");
        break;
    case 6:
        Console.WriteLine(day + " - Суббота - выходной");
        break;
    case 7:
        Console.WriteLine(day + " - Воскресенье - выходной");
        break;
    default:
        Console.WriteLine("Ваша цифра не соответствует ни одноу дню недели");
        break;
}