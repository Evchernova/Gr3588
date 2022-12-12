//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");
int res = Pow(numberA, numberB);
PrintResult(res);

//запрос данных у пользователя
int ReadData(string line)
 {
     //выводим сообщение
     Console.Write(line);
     //считываем число
     int numberP = int.Parse(Console.ReadLine() ?? "0");
     return numberP; //возвращаем значение
 }

// Метод вывода результата
void PrintResult(int res)
 {
    Console.WriteLine(res);
 }

//Метод возведения в степень
int Pow(int a, int b)
 {
    int res = 1;
    for (int i = 1; i<=b; i++)
    {
        res = a*res;
    }
    return res;
 }
