//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

  int xh = ReadData("Введите xh: ");
  int yh = ReadData("Введите yh: ");
  int zh = ReadData("Введите zh: ");
  int xv = ReadData("Введите xv: ");
  int yv = ReadData("Введите yv: ");
  int zv = ReadData("Введите zv: ");

 double CalculateLength(int x1, int x2, int y1, int y2, int z1, int z2)
 {
     double res = 0;
     res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
     return res;
 }


 void PrintData(string msg, double result)
 {
     Console.WriteLine(msg + result);
 }

 PrintData("Расстояние между точками ", CalculateLength(xh, xv, yh, yv, zh, zv));