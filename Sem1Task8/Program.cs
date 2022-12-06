//Считываем данные с консоли
string? num1Line = Console.ReadLine()??"0";

 //Парсим введенные числа
int startNumber = int.Parse(num1Line);

int num2 = 2;

 //Выходное значение
string outLine = string.Empty;

while (num2 <= startNumber)
{
    outLine = outLine + num2 + ", ";
    num2 = num2 + 2;
}
Console.WriteLine(outLine);
