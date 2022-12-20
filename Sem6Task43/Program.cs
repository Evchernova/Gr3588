// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int b1 = ReadData("Введите точку b1: ");
int k1 = ReadData("Введите точку k1: ");
int b2 = ReadData("Введите точку b2: ");
int k2 = ReadData("Введите точку k2: ");
CrossPoint(b1, k1, b2, k2);


//Метод, считывающий данные, введенные пользователем
 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

//Метод поиска точки пересечения двух прямых
void CrossPoint(double b1, double k1, double b2, double k2)
{
double x = (b1-b2)/(k2-k1); //В первом уравнении находим x
double y = (k2*b1-k1*b2)/(k2-k1); //Находим y, подставив найденное значение x во второе уравнение
 
if (k1==k2)Console.WriteLine ("Заданные прямые не пересекаются.");
else Console.WriteLine("Точка пересечения заданных прямых: " + (x,y));
}