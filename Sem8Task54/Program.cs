//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

//Метод сортировки элементов в строке от максимального к минимальному
void SortMaxToMin(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];
Fill2DArray(matrix, 1, 9);
Console.WriteLine("Исходный массив:");
Print2DArray(matrix);
Console.WriteLine("Отсортированный массив:");
SortMaxToMin(matrix);
Print2DArray(matrix);