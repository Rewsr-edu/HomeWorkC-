/*
// Задача 1
Console.WriteLine("Введите первое целое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine ("Первое число больше");
}
if (a < b)
{
    Console.WriteLine ("Второе число больше");
}
if (a == b)
{
    Console.WriteLine ("Числа равны");
}
// Задача 2
Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
       Console.WriteLine ("Первое число больше");
    }
    if (a < c)
    {
        Console.WriteLine ("Третье число больше");
    }
}
if (a < b)
{
    if (b > c)
    {
       Console.WriteLine ("Второе число больше");
    }
    if (b < c)
    {
        Console.WriteLine ("Третье число больше");
    }
}
if (a == b)
{
    if (a > c)
    {
       Console.WriteLine ("Первое и второе числа больше");
    }
    if (a < c)
    {
        Console.WriteLine ("Третье число больше");
    }
    if (a == c)
    {
        Console.WriteLine ("Все числе одинаковые");
    }
}
if (b == c)
{
    if (a < c)
    {
       Console.WriteLine ("Второе и третье числа больше");
    }
}    


// Задача 3

Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine ("Да, четное ");
}
else
{
    Console.WriteLine ("Нет, нечетное ");
}

// Задача 4 
Console.WriteLine("Введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;
while(b <= a)
{
       Console.Write(b);
       b = b + 2;
              if(b <= a)
       {
           Console.Write(" , ");
       }
}

// Задача 5
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
if (a > 999)
{
    Console.WriteLine("Некорретное число");
}
if (a < 100 )
{
    Console.WriteLine("Некорретное число");

}
else
{ a = a%10;
Console.WriteLine(a);
}
*/