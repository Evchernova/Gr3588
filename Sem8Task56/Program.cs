//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Чтение данных из консоли
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

 //Заполняем массив случайными числами
 void Fill2DArray(int[,] matr, int min, int max)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i, j] = new Random().Next(min, max + 1);
         }
     }
 }

 //Печать двумерного массива
 void Print2DArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i, j]} ");
         }
         Console.WriteLine();
     }
     Console.WriteLine();
 }

//Метод для поиска индекса строки с минимальной суммой элементов
int MinRow(int[,] arr)
{
    int minIndex = -1;
    int minRow = int.MaxValue;

    for(int i=0; i<arr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j=0; j<arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        if(minRow > sum) 
        {
            minRow = sum; minIndex = i;
        }
    }
    return minIndex;
}

//Печать результата в консоль
void PrintData(string msg, int result)
 {
     Console.WriteLine(msg + result);
 }

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];
Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);
PrintData("Строка с минимальной суммой элементов имеет индекс i = " , MinRow(matrix));
