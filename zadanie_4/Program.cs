int[,,] newThreeArray(int n, int[] collection)
{
    int[,,] array = new int[n,n,n];
    int num = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = collection[num];
                num++;
            }
        }
    }
    return array;
}
void printArray(int[,,] coll)
{
    for(int i = 0; i < coll.GetLength(0); i++)
    {
        for(int j = 0; j < coll.GetLength(1); j++)
        {
            for(int k = 0; k < coll.GetLength(2); k++)
            {
            Console.Write($"{coll[i,j,k]} - [{i},{j},{k}]  ");
            }
            Console.WriteLine();
        }
    }
}

int[] randomNumbers(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for(int index = 0; index < arr.Length; index++)
    {
        int a = rnd.Next(10, 100);
        for(int count = 0; count < index; count++)
        {
            if(a == arr[count])
            {
                index--;
            }
        }
        arr[index] = a;
    }
    return arr;
}
int[] arr = randomNumbers(8);
int[,,] array = newThreeArray(2, arr);
printArray(array);
