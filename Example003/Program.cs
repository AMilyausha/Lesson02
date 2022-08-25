int a;
Console.WriteLine("Введите число от 1 до 7");
a=int.Parse(Console.ReadLine());
if (a<=5)
{
 Console.WriteLine ("Нет,рабочий");
}
else if (a<=7)
{
 Console.WriteLine ("Да,выходной");
}
else{
    Console.WriteLine ("Введенное число не соответствует условиям");
}