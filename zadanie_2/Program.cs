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
           Console.Write($"[{string.Join(", ", array[i,j])}]");
        Console.WriteLine();
    }
}
int GetNumFromArray(int[,] collection)
{
    int result;
Console.WriteLine("Введите позиции элемента массива через пробел, а программа выдаст вам значение этого элемента.");
string input = Console.ReadLine()!;
string[] numdersString = input.Split(" ");
int[] numbers = new int[numdersString.Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(numdersString[i]);
}
if(numbers[0] > collection.GetLength(0) || numbers[1] > collection.GetLength(1)){
    result = -1;
    Console.Write("такого элемента в массиве нет.");
    }
    else{
    result = collection[numbers[0], numbers[1]];
    Console.WriteLine(result);
    }
    return result;
}

int[,] array = generateArray(3,4,-10,10);
printArray(array);
GetNumFromArray(array);



