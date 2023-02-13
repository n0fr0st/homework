
int[,] SpiralArray(int n, int m)
        {
            int[,] array = new int[n, m];
            int indexj = 0, indexi = 0, x = 1, y = 0, directionChanges = 0, direction = m;
            for (int i = 0; i < array.Length; i++)
            {
                array[indexj, indexi] = i + 1;
                if (--direction == 0)
                {
                   
                    direction = m*(directionChanges%2) + n*((directionChanges + 1)%2) - (directionChanges/2 - 1) - 2;
                    int Oldx = x;
                    x = -y;
                    y = Oldx;
                    directionChanges++;
                }
                array[indexj, indexi] = i + 1;
                indexi += x;
                indexj += y;
            }
            return array;
        }
void printArray(int[,] array){
        for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,3}",array[i,j]);
        Console.WriteLine();
    }
}
printArray(SpiralArray(4, 4));