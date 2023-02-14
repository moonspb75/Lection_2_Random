// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int num = new  Random().Next(100,1000);
Console.WriteLine(num);
int buf = num % 10;
int buf2 = num / 100;

num = (buf2 * 10) + buf;
Console.WriteLine(num);