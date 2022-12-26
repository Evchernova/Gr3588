//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

 //Метод произведения двух матриц
 void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] newMatrix)
{
  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      newMatrix[i,j] = sum;
    }
  }
}


int i = ReadData("Введите количество строк для первой матрицы: ");
int j = ReadData("Введите количество столбцов для первой матрицы и строк для второй: "); //Произведение двух матриц выполнимо только в случае, если количество столбцов первой матрицы равно количеству строк второй.
int k = ReadData("Введите количество столбцов для второй матрицы: ");
int[,] FirstMatrix = new int[i, j];
Fill2DArray(FirstMatrix, 1, 9);
Console.WriteLine("Первая матрица:");
Print2DArray(FirstMatrix);
int[,] SecondMatrix = new int[j, k];
Fill2DArray(SecondMatrix, 1, 9);
Console.WriteLine("Вторая матрица:");
Print2DArray(SecondMatrix);
int[,] NewMatrix = new int[i,k];
MultiplyMatrix(FirstMatrix, SecondMatrix, NewMatrix);
Console.WriteLine("Произведение двух матриц равно:");
Print2DArray(NewMatrix);