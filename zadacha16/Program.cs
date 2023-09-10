Console.WriteLine("Введите Цифру от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
switch(x)
{
    case 1 :
    Console.WriteLine("Понедельник");
    break;
    case 2 :
    Console.WriteLine("Вторник");
    break;
    case 3 :
    Console.WriteLine("Среда");
    break;
    case 4 :
    Console.WriteLine("Четверг");
    break;
    case 5 :
    Console.WriteLine("Пятница");
    break;
    case 6 :
    Console.WriteLine("Суббота");
    break;
    case 7 :
    Console.WriteLine("Воскресенье");
    break;
}
if((x>5)&&(x<=7))
{
    Console.WriteLine("Ура, выходной!");
}
if(x<5)
{
    Console.WriteLine("Будний день");
}
if(x>7)
{
    Console.WriteLine("Нет такого дня недели");
}
Console.ReadKey();