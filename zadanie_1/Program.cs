double[,] generateArray(int m, int n, int min,int max){
    double[,] arrNum = new double[m, n];
    Random rnd = new Random();

    for(int i = 0; i < arrNum.GetLength(0); i++){
        for(int j = 0; j < arrNum.GetLength(1); j++)
           arrNum[i, j] = (double)rnd.Next(10*min, 10*max)/10;
    }
    return arrNum;
}
void printArray(double[,] array){
        for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write($"[{string.Join(", ", array[i,j])}]");
        Console.WriteLine();
    }
}
printArray(generateArray(3,4,-10,10));

