//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

 int[] array = GenArray(15, 100, 999);
 Print1DArr(array);
 int res = CountEven(array);
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

 int CountEven(int[] arr) //метод подсчета четных элементов в массиве
 {
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)  //если элемент делится на 2 без остатка, прибавляем к результату единицу
        res++;
    }
    return res;
 }