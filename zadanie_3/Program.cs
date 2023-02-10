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
            Console.Write($"[{string.Join(", ", array[i,j])}]");
    
        }        
    Console.WriteLine();
    }
    
}
int divNum(int[,] collection)
{
    int res = 0;
        for(int j = 0; j < collection.GetLength(1); j++)
    {
        float result = 0;
        for(int i = 0; i < collection.GetLength(0); i++)
        {
            result += collection[i,j];
        }  
        Console.WriteLine($" среднее арифметическое для {j+1} столбца - {result/collection.GetLength(0):f1}");    
    }
    return res;
}
int[,] array = generateArray(3, 4, 0, 10);
printArray(array);
divNum(array);