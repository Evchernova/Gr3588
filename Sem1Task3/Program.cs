﻿//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine != null)
{
    //Создаем массив с днями недели
    //string[] dayOfWeek = new string[7];
    //dayOfWeek[0] = "понедельник";
    //dayOfWeek[1] = "вторник";
    //dayOfWeek[2] = "среда";
    //dayOfWeek[3] = "четверг";
    //dayOfWeek[4] = "пятница";
    //dayOfWeek[5] = "суббота";
    //dayOfWeek[6] = "воскресенье";

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим название дня недели по введенному номеру
    //string outDayOfWeek = dayOfWeek[inputNumber-1];

    string outDayOfWeek = string.Empty;
    //switch(inputNumber)
    //{
    //case 1:   outDayOfWeek[0] = "понедельник"; break;
    //case 2:   outDayOfWeek[1] = "вторник"; break;
    //case 3:   outDayOfWeek[2] = "среда"; break;
    //case 4:   outDayOfWeek[3] = "четверг"; break;
    //case 5:   outDayOfWeek[4] = "пятница"; break;
    //case 6:   outDayOfWeek[5] = "суббота"; break;
    //case 7:   outDayOfWeek[6] = "воскресенье"; break;
    //default:  outDayOfWeek = "это не день недели!";
    //}

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));

    //Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);
}