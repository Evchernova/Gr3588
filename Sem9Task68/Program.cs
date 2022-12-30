//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Чтение данных из консоли
 uint ReadData(string line)
 {
     Console.Write(line);
     uint number = uint.Parse(Console.ReadLine() ?? "0");
     return number;
 }

 // Печать результата
 void PrintResult(uint prefix)
 {
     Console.WriteLine(prefix);
 }

//Метод вычисления функции Аккермана с помощью рекурсии
uint Akk(uint m, uint n) //uint - то же самое, что int, но больше нуля
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
}
 
 uint number1 = ReadData("Введите число M: ");
 uint number2 = ReadData("Введите число N: ");
 uint resultLine = Akk(number1, number2);
 PrintResult(resultLine);
