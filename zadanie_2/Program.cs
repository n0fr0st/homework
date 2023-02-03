int[] GenArray(int n)
{
        int[] array = new int[n];
        Random rnd = new Random();
        for (int index = 0; index < array.Length; index++)
        {
                array[index] = rnd.Next(-100, 101);
        }
        return array;
}
int summOfElements(int[] coll)
{
    int result = 0;
    for(int i = 0; i < coll.Length; i++)
    {
        if(i%2 != 0)
                result += coll[i];
    }
    Console.WriteLine($"Сумма нечетных элементов - {result}");
    return result;
}
void printArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
System.Console.WriteLine("Введите число колличества элементов массива и программа вычислит сумму всех нечетных элементов этого массива.");
int[] array = GenArray(Convert.ToInt32(Console.ReadLine()));
printArray(array);
summOfElements(array);