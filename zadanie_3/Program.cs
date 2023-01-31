void newArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine(" error try again");
        }
        collection[index] = x;
        index++;
    }
}
void printArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(coll[position] + ", ");
        position++;
    }
}
Console.WriteLine("Введите числа и программа их выведет в виде массива.");
int[] n = new int [8];
newArray(n);
printArray(n);