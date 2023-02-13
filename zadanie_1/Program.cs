int[,] generateArray(int m, int n, int min, int max){
    int[,] arrNum = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < arrNum.GetLength(0); i++){
        for(int j = 0; j < arrNum.GetLength(1); j++)
           arrNum[i, j] = rnd.Next(min, max);
    }
    return arrNum;
}
void printArray(int[,] array){
        for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,3}",array[i,j]);
        Console.WriteLine();
    }
}

void minOfArray(int[,] array)
{        
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                int minPosition = j;
                for (int k = j + 1; k  < array.GetLength(1); k++)
                {
                    if(array[i,k] > array[i,minPosition]) minPosition = k;   
                }
                    int temporary =array[i,minPosition] ;
                    array[i,minPosition] = array[i,j];
                    array[i,j] = temporary;
                    Console.Write("{0,3}",array[i,j]);
            }
            Console.WriteLine();
        }
}
Console.WriteLine("Программа генерирует двумерный массив, и упорядочивает его по убыванию.");
int[,] array = generateArray(3,4,0,10);
printArray(array);
Console.WriteLine("Упорядоченный массив...");
minOfArray(array);

