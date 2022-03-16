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
*/

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