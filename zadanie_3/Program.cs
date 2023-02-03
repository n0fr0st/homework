float[] GenArray(int coll)
{
    float[] arr = new float[coll];
    float result;
    for(int index = 0; index < arr.Length; index++)
    {
        Console.WriteLine($"Введите {index+1} элемент массива.");
        while (!float.TryParse(Console.ReadLine(), out result))
        {
                Console.WriteLine(" error try again");
        }
        arr[index] = result;
    }
    return arr;
}
float diff(float[] coll)
{
    float max = coll[0];
    float min = coll[0];
    for(int i = 0; i < coll.Length; i++)
    {
        if(coll[i] > max)
            max = coll[i];
        if(coll[i] < min)
            min = coll[i];
    }
    float result = max - min;
    Console.WriteLine(result);
    return result;
}
void printArray(float[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
Console.WriteLine("Введите количество чисел в массиве и элементы этого массива, после программа вычислит разницу между максимальным элементом этого массива и минимальным.");
float[] array = GenArray(Convert.ToInt32(Console.ReadLine()));
printArray(array);
diff(array);