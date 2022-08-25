int start = 1;
int stop = 65537;
int value = new Random().Next(start,stop);
string a  = value.ToString();
char[] num = new char[a.Length];
for(int index = 0; index < a.Length; index++){
    num[index] = a[index];
    }
if (value <=99){
    Console.WriteLine("Третьей цифры нет");
}
else {
Console.WriteLine(value);
Console.WriteLine(num[2]);
}
