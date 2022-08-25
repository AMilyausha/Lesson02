int start = 100;
int stop = 1000;
int value = new Random().Next(start,stop);
string a  = value.ToString();
char[] num = new char[a.Length];
for(int index = 0; index < a.Length; index++){
    num[index] = a[index];
    }
Console.WriteLine(value);
Console.WriteLine(num[1]);