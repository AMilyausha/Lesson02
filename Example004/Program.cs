int start = 100;
int stop = 1000000;
int value = new Random().Next(start,stop);
if ((value%7==0) && (value%23==0))
{
    Console.WriteLine("Да, кратно");
}
else
{
    Console.WriteLine("Нет");
}