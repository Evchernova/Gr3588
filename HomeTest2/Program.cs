// * Найдите площадь треугольника образованного пересечением 3 прямых 
 //   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

 double coefficientK1 = ReadData("Input number K1: ");
 double coefficientB1 = ReadData("Input number B1: ");
 double coefficientK2 = ReadData("Input number K2: ");
 double coefficientB2 = ReadData("Input number B2: ");
 double coefficientK3 = ReadData("Input number K3: ");
 double coefficientB3 = ReadData("Input number B3: ");
 // Вводим перменную для строки с координатами.
 string dots = CrossPoint1(coefficientK1, coefficientB1, coefficientK2, coefficientB2, coefficientK3, coefficientB3);
 // Разбиваем строку на строковый массив.
 string[] dotsArr = dots.Split(';');
 // Преобразуем строковое значение коррдинат в вещественный тип, чтобы использовать в дальнейших рассчетах.
 double X1 = double.Parse(dotsArr[0]);
 double Y1 = double.Parse(dotsArr[1]);
 double X2 = double.Parse(dotsArr[2]);
 double Y2 = double.Parse(dotsArr[3]);
 double X3 = double.Parse(dotsArr[4]);
 double Y3 = double.Parse(dotsArr[5]);
 PrintData($"Cross points of 3 lines: X1= {X1}; Y1= {Y1}, X2= {X2}; Y2= {Y2}, X3= {X3}; Y3= {Y3}");
 double sideA = TriangleSideA(X1, Y1, X2, Y2);
 double sideB = TriangleSideB(X2, Y2, X3, Y3);
 double sideC = TriangleSideC(X3, Y3, X1, Y1);
 PrintData($"The length of triangle sides: A= {sideA}; B= {sideB}, C= {sideC}");
 PrintData($"The square of triangle: S= {SquareTriangle(sideA, sideB, sideC)}");

 // Метод считывания введенных данных.
 double ReadData(string msg)
 //==========================================
 //#52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
 //столбце. * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом
 //==========================================

 // Запрос данных пользователяю, принимает строку заголовок.
 // Выдает введеное число, в случае ошибки выдает 0.
 int ReadData(string greeting = "Введите данные")
 {
     Console.Write(msg);
     return double.Parse(Console.ReadLine() ?? "0");
     Console.WriteLine(greeting);
     int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
     return (number);
 }
 // Метод вывода данных.
 void PrintData(string msg)

 // Генерация случайного 2D массива.
 int[,] Gen2DArr(int countRow, int countColumn, int arrMin, int arrMax)
 {
     Console.WriteLine(msg);
     int[,] arr2D = new int[countRow, countColumn];
     Random rnd = new Random();

     if (arrMin > arrMax)
     {
         int temp = arrMax;
         arrMax = arrMin;
         arrMin = temp;
     }

     for (int i = 0; i < arr2D.GetLength(0); i++)
     {
         for (int j = 0; j < arr2D.GetLength(1); j++)
         {
             arr2D[i, j] = rnd.Next(arrMin, arrMax);
         }
     }
     return arr2D;
 }
 // Находим точки пересечния трех прямых в одном методе, результат выводим с строковом виде.
 string CrossPoint1(double k1, double b1, double k2, double b2, double k3, double b3)

 // Печатает двумерный массив в цвете по диоганали.
 void Print2DArrayDigonalColor(int[,] array, int bias = 0)
 {
     string res = string.Empty;
     double coorX1 = (b2 - b1) / (k1 - k2);
     double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
     double coorX2 = (b3 - b2) / (k2 - k3);
     double coorY2 = (k2 * b3 - k3 * b2) / (k2 - k3);
     double coorX3 = (b1 - b3) / (k3 - k1);
     double coorY3 = (k3 * b1 - k1 * b3) / (k3 - k1);
     return res = $"{coorX1}; {coorY1};{coorX2};{coorY2};{coorX3};{coorY3}";
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.ForegroundColor = GetColorСell(i + bias, j);
             Console.Write(array[i, j] + " ");
             Console.ResetColor();
         }
         Console.WriteLine();
     }
 }
 //Находим стороны треугольника, разбила на 3 отдельных метода, чтобы получить сразу переменные в double.
 double TriangleSideA(double x1, double y1, double x2, double y2)

 // Задает цвет ячейки.
 // Принимает индексы, возвращает цвет.
 ConsoleColor GetColorСell(int i, int j)
 {
     double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
     return result;
     ConsoleColor[] col = new ConsoleColor[]
     {
         ConsoleColor.Black,
         ConsoleColor.Blue,
         ConsoleColor.Cyan,
         ConsoleColor.DarkBlue,
         ConsoleColor.DarkCyan,
         ConsoleColor.DarkGray,
         ConsoleColor.DarkGreen,
         ConsoleColor.DarkMagenta,
         ConsoleColor.DarkRed,
         ConsoleColor.DarkYellow,
         ConsoleColor.Gray,
         ConsoleColor.Green,
         ConsoleColor.Magenta,
         ConsoleColor.Red,
         ConsoleColor.White,
         ConsoleColor.Yellow
     };

     int numCol = (j - i) % col.Length;
     if (numCol < 0)
         numCol = col.Length + numCol;
     return col[numCol];
 }
 double TriangleSideB(double x2, double y2, double x3, double y3)

 // Считает среднее арифметическое по столбцам.
 double[] AverageСolumn(int[,] array2D)
 {
     double result = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
     return result;
     double[] arrayAverage = new double[array2D.GetLength(1)];
     int sum = 0;

     for (int j = 0; j < array2D.GetLength(1); j++)
     {
         for (int i = 0; i < array2D.GetLength(0); i++)
         {
             sum += array2D[i, j];
         }
         arrayAverage[j] = Math.Round((double)sum / array2D.GetLength(0), 2);
         sum = 0;
     }
     return arrayAverage;
 }
 double TriangleSideC(double x3, double y3, double x1, double y1)

 // Считает среднее арифметическое по диоганали.
 double[] AverageDioganal(int[,] array2D)
 {
     double result = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
     return result;
     double[] arrayAverage = new double[array2D.GetLength(0) + array2D.GetLength(1) - 1];
     int sum = 0;
     int iStart = array2D.GetLength(0) - 1;
     int iFinish = array2D.GetLength(0);
     int jStart = 0;
     int j = 0;
     int n = 0;

     for (int k = 0; k < array2D.GetLength(0) + array2D.GetLength(1) - 1; k++)
     {
         for (int i = iStart; i < iFinish; i++)
         {
             sum = sum + array2D[i, j];
             n++;
             j++;
         }

         iStart--;
         if (iStart < 0)
         {
             iStart = 0;
             jStart++;
         }
         if (j > array2D.GetLength(1) - 1)
             iFinish--;

         j = jStart;
         arrayAverage[k] = Math.Round((double)sum / n, 2);
         sum = 0;
         n = 0;
     }

     return arrayAverage;
 }

 // Печатает одномерный массив в цвете по последней строке массива.
 void Print1DArrayColor(string message, double[] array, int row)
 {
     int i;
     Console.Write(message);
     for (i = 0; i < array.Length - 1; i++)
     {
         Console.ForegroundColor = GetColorСell(row - 1, i);
         Console.Write(array[i] + " ");
         Console.ResetColor();
     }
     Console.ForegroundColor = GetColorСell(row - 1, i);
     Console.WriteLine(array[array.Length - 1]);
     Console.ResetColor();
 }
 // Находим площадь треугольника через полумериметр (p=(a + b + c) / 2 )сторон и длины сторон.
 double SquareTriangle(double a, double b, double c)

 int row = ReadData("Введите количество строк ");
 int column = ReadData("Введите количество столбцов ");

 int[,] arr2D = Gen2DArr(row, column, 10, 100);
 Print2DArrayDigonalColor(arr2D);

 Print1DArrayColor("Среднее арифметическое по столбцам: ", AverageСolumn(arr2D), row);
 Print1DArrayColor("Среднее арифметическое по диогонали: ", AverageDioganal(arr2D), row);

  DateTime time = DateTime.Now; // Радуга диоганальная
 int n = 0;
 Console.Clear();
 while (true)
 {
     double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
     return squareT;
 }
     if ((DateTime.Now - time) > TimeSpan.FromMilliseconds(100))
     {
         Console.SetCursorPosition(0, 0);
         arr2D = Gen2DArr(row, column, 10, 100);
         Print2DArrayDigonalColor(arr2D, n);
         n++;
         time = DateTime.Now;
     }
 