//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GenArray(4, 13, 15);
Print1DArr(array);
double res = MinMax(array);
PrintData(res);


double[] GenArray(int len, double minValue, double maxValue) //генерируем массив
 {
     double[] arr = new double[len];
     for (int i = 0; i < arr.Length; i++)
     {
        //генерация рандомных вещественных элементов массива. NextDouble генерирует значения от 0 до 1, поэтому
        //чтобы сгенерировать элементы из заданного диапазона, нужно полученные значения умножить на разницу между 
        //макс и мин элементами, а потом к результату прибавить минимальное значение
         arr[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; 
     }
     return arr;
 }

 void Print1DArr(double[] arr) //выводим массив в консоль
 {
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1]);
 }

 void PrintData(double res) //выводим результат
 {
     Console.WriteLine(res);
 }



double MinMax(double[] arr) //метод нахождения разницы между макс и мин элементами массива
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    res = max-min;
    return res;
}


