//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int number = ReadData("Сколько чисел вы хотите ввести?");
int res = CountPosNum(number);
PrintData(res);

//Метод, считывающий данные, введенные пользователем
 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

 //Метод, выводящий на печать данные пользователю
 void PrintData(int res)
 {
     Console.WriteLine(res);
 }

//Метод для подсчета положительных чисел из чисел введенных пользователем
 int CountPosNum(int N)
 {
    int res = 0;
    while (N > 0)
    {
    if(ReadData("Введите число: ") > 0)res++;
    N = N - 1;
    }
    return res;
 }