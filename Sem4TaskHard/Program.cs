//Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал

string ReadData(string msg)
 {
     Console.WriteLine(msg);
     return Console.ReadLine();
 }

string text = ReadData("Введите имена через запятую: ");
string[] names = text.Split(','); 
Console.WriteLine(names[new Random().Next(0, names.Length)]);
