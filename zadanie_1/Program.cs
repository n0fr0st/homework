int[] GenArray(int n)
{
    int[] arr = new int[n];
    Random rndm = new Random();
    for(int i = 0; i < arr.Length; arr[i++] = rndm.Next(100, 1000)){}
    return arr;
}
int sumOfEven(int[] coll)
{
    int res = 0;
    for(int index = 0; index < coll.Length; index++)
    {
        if(coll[index]%2 == 0)
            res += 1;
    }
     Console.WriteLine($"Ответ - {res}");
    return res;
}
void printArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

Console.WriteLine("Введите колличество эллементов массива и программа вычислит сколько среди этих элементов четных чисел.");
int[] array = GenArray(Convert.ToInt32(Console.ReadLine()));
printArray(array);
sumOfEven(array);

