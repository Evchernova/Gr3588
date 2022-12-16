//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(15, 1, 50);
Print1DArr(array);
int res = SumOdd(array);
PrintData(res);

int[] GenArray(int len, int minValue, int maxValue) //генерируем массив
 {
     int[] arr = new int[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = new Random().Next(minValue, maxValue + 1);
     }
     return arr;
 }

 void Print1DArr(int[] arr) //выводим массив в консоль
 {
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1]);
 }

 void PrintData(int res) //выводим результат
 {
     Console.WriteLine(res);
 }

 int SumOdd(int[] arr) //метод поиска суммы элементов, стоящих на нечетных позициях
 {
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i]; //res = arr[i]+res 
        i = i + 2;
    }
    return res;
 }