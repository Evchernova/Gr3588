//Считываем данные с консоли
string? num1Line = Console.ReadLine()??"0";

 //Парсим введенные числа
int num1 = int.Parse(num1Line);

int num2 = num1 %2;

if (num2 == 0)
{
    Console.WriteLine("четное"); 
}

else
{
    Console.WriteLine("нечетное");
}