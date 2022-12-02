int num = new System.Random().Next(100,1000);

Console.WriteLine(num);

//int firstNum = num/100;
//int secondNum = num%10;

//int result = firstNum*10+secondNum;

int result = (num/100)*10+num%10;

Console.WriteLine(result);
Console.WriteLine((num/100)*10+num%10);