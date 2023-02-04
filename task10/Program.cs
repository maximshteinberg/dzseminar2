// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number<999) 
{
  int num1 = (number/10)%10;
  System.Console.WriteLine("второе число: " + num1);
}
else System.Console.WriteLine("Число не трехзначное");