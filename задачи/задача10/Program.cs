//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите число: ");
string input = Console.ReadLine();
char[] CharArray = input.ToCharArray();
if(CharArray.Length > 3 | CharArray.Length < 3) Console.WriteLine("Введено не трехзначное число ");
else Console.WriteLine(CharArray[1]);

