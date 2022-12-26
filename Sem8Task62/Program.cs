//Напишите программу, которая заполнит спирально массив 4 на 4

 //Заполняем массив порядковыми числами по спирали
 void FillSpiral(int[,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
 }

 //Печать двумерного массива
 void Print2DArray(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write(matrix[i, j]+"     ".Substring(matrix[i, j].ToString().Length));
         }
         Console.WriteLine();
     }
     Console.WriteLine();
 }

int[,] matrix = new int[4, 4];
FillSpiral(matrix);
Print2DArray(matrix);