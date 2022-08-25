int a;
Console.WriteLine("Введите число от 1 до 7");
a=int.Parse(Console.ReadLine());
switch (a)
 {
    case <=5:
    Console.WriteLine("Нет, рабочий");
    break;
     case <=7:
    Console.WriteLine("Да, выходный");
    break;
    default:
    Console.WriteLine("Введенное число не соответствует условиям!");
    break;
 }