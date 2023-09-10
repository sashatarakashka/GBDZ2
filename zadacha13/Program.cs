Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

if(x<100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(x>1000)
{
int num1 = x%100;
int num = num1/10;
Console.WriteLine(num);
}
if((x>100)&&(x<1000))
{
    int num = x%10;
    Console.WriteLine(num);
}

Console.ReadKey();