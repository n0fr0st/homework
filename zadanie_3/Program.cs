int[,] generateArray(int m, int n){
    int[,] arrNum = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < arrNum.GetLength(0); i++){
        for(int j = 0; j < arrNum.GetLength(1); j++)
           arrNum[i, j] = rnd.Next(1, 5);
    }
    return arrNum;
}

int[,] newmatr(int[,] firstColl, int[,] secondColl)
{
    int[,] matrix = new int[firstColl.GetLength(0),secondColl.GetLength(1)];
    for(int i = 0; i < firstColl.GetLength(0); i++)
    {
        for(int j = 0; j < secondColl.GetLength(1); j++)
        {
            for(int k = 0; k < secondColl.GetLength(0); k++)
            {
                matrix[i,j] += firstColl[i,k]*secondColl[k,j];
            }
        }
    }
    return matrix;

}


void printArray(int[,] array){
        for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,3}",array[i,j]);
        Console.WriteLine();
    }
}

int[,] array1 = generateArray(2, 2);
int[,] array2 = generateArray(2, 2);
int[,] MATRIXnew = newmatr(array1,array2);
printArray(array1);
System.Console.WriteLine("  ____");
printArray(array2);
Console.WriteLine("При переможении двух матриц данных программой получается эта:");
printArray(MATRIXnew);

