// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



System.Console.Write("Введите номер дня недели: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1<1 || n1>7) 
{
    System.Console.WriteLine("Неправильно введен день недели");
}
else
if (n1==6 || n1==7) 
{
    System.Console.WriteLine("этот день выходной");
}
else 
{
    System.Console.WriteLine("этот день рабочий");
}
