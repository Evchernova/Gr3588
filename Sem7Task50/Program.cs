//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Метод считывает введенную пользователем информацию
int ReadData(string line) 
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

// Универсальный метод генерации и заполнение двумерного массива
int [,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
 {
     System.Random rand = new System.Random();
     int[,] array2D = new int[countRow, countColumn];

     for (int i = 0; i < countRow; i++)
     {
         for (int j = 0; j < countColumn; j++)
         {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
         }
     }
     return array2D;
 }

//Метод печати двумерного массива в цвете
 void Print2DArrayColor(int[,] matrix)
 {
     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                         ConsoleColor.Yellow};

     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.ForegroundColor = col[new System.Random().Next(0,16)];
             Console.Write(matrix[i, j]+"     ".Substring(matrix[i, j].ToString().Length));
             Console.ResetColor(); 
             System.Threading.Thread.Sleep(100);//Пауза после выполнения действий внутри цикла J на 100мс
         }
         Console.WriteLine();
     }
 }

//Метод, выводящий на печать данные пользователю
 void PrintData(int res)
 {
     Console.WriteLine(res);
 }

//Метод поиска элемента по введенному индексу элемента
 int SearchElem(int[,] arr, int x, int y)
 {
    int elem = -1;
    if(x < arr.GetLength(0))
    {
        if(y < arr.GetLength(1))
        {
            elem = arr[x, y];
        }
    }
    return elem;
 }


int[,] arr2D = Fill2DArray(7, 5, 10, 99);
Print2DArrayColor(arr2D);
int x = ReadData("Введите первый индекс элемента: ");
int y = ReadData("Введите второй индекс элемента: ");
int res = SearchElem(arr2D, x, y);
if (SearchElem(arr2D, x, y)== -1)
{
    Console.WriteLine("Не существует элемента с таким индексом!");
}
else PrintData(res);