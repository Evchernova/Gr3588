//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = ReadData("Введите число: ");
bool result = PalinTest(num);
PrintData(result);

//Метод читает данные от пользователя
 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

// Метод вывода данных
void PrintData(bool res)
{
    Console.WriteLine(res);
 }

//Метод проверки на палиндром
bool PalinTest(int num)
{
    bool res = false;
    res = (num/10000 == num%10) && ((num/1000)%10 == (num/10)%10);
    return res;
}