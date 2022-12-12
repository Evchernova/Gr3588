 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadData ("Введите число: ");
int res = SumDigit(number);
PrintResult( "Сумма цифр в числе равна " +res);

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
void PrintResult(string line)
 {
    Console.WriteLine(line);
 }

//Метод подсчета суммы цифр в числе
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num%10; //res = res+num%10
        num = num/10;
    }
    return res;
}