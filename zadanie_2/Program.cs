int[,] generateArray(int m, int n, int min, int max){
    int[,] arrNum = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < arrNum.GetLength(0); i++){
        for(int j = 0; j < arrNum.GetLength(1); j++)
           arrNum[i, j] = rnd.Next(min, max);
    }
    return arrNum;
}
void printArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}",array[i,j]);
    
        }        
    Console.WriteLine();
    }
    
}
void divNum(int[,] collection)
{
    int[] result = new int [collection.GetLength(0)];
    int min = 0;
    int minval = 0;
    int rowsValue = 0;
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        sum += collection[i,j];
        }
        result[i] = sum; 
    }
        min = result[0];
    for(int index = 0; index < collection.GetLength(0);index++)
    {
        if (min > result[index])
        {
            min = result[index];
            rowsValue = index;
        }
        minval = min;
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов - {rowsValue + 1}, сумма элементов этой строки - {min}");
}
int[,] array = generateArray(4, 4, 0, 10);
printArray(array);
divNum(array);



