void newArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void printArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(coll[position] + " ");
        position++;
    }
}
int[] n = new int [8];
newArray(n);
printArray(n);
