//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

 void PrintData(string res, int[] arr)
 {
     Console.WriteLine(res);
     PrintArr(arr);
 }

 int[] GenArr(int num)
 {
     Random rnd = new Random();
     int[] arr = new int[num];
     int min = ReadData("Введите минимальную цифру в массиве: ");
     int max = ReadData("Введите максимальную цифру в массиве: ");
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = rnd.Next(min,max);
     }
     return arr;
 }

 void PrintArr(int[] arr)
 {
     Console.Write("[");
     for (int i = 0; i < arr.Length-1; i++)
     {
         Console.Write(arr[i]+", ");
     }
     Console.WriteLine(arr[arr.Length-1]+"]");
 }

 int arrLen = ReadData("Введите длину массива: ");
 int[] arr = GenArr(arrLen);
 PrintData("Сгененрированный массив:",arr);