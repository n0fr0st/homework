double rasstoyanie (int xA,int xB,int yA,int yB,int zA,int zB)
{
    double result = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    // Console.WriteLine(xB-xA);
    // Console.WriteLine(yB-yA);
    // Console.WriteLine(zB-zA);
    return result;
}
Console.WriteLine("программа нахождения растояния между точками в плоскостию");
Console.WriteLine("Введите координаты точки A");

if(!int.TryParse(Console.ReadLine(), out var xA))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}
if(!int.TryParse(Console.ReadLine(), out var yA))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}
if(!int.TryParse(Console.ReadLine(), out var zA))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}


Console.WriteLine("Введите координаты точки B");
if(!int.TryParse(Console.ReadLine(), out var xB))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}
if(!int.TryParse(Console.ReadLine(), out var yB))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}
if(!int.TryParse(Console.ReadLine(), out var zB))
{
    Console.WriteLine(" error try again");
    Console.ReadLine();
}

Console.WriteLine(rasstoyanie(xA,xB,yA,yB,zA,zB));
