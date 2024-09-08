// See https://aka.ms/new-console-template for more information

Console.WriteLine("Завдання 1");
int month, day;

Console.WriteLine("Введіть  перше число: ");
month = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть  друге число: ");
day = int.Parse(Console.ReadLine());
//перевірка день/місяць
if ((month > 0) & (month <= 12))
{
    if (
        ((month == 1) | (month == 3) | (month == 5) | (month == 7) | (month == 8) | (month == 10) | (month == 12))
        & (day >=1 ) & (day<=31)
       )
       Console.WriteLine(true);
    else
    if (
        (month == 2)
        & (day >= 1) & (day <= 28)
       )
       Console.WriteLine(true);
    else
    if (
         ((month == 4) | (month == 6) | (month == 9) | (month == 11))
        & (day >= 1) & (day <= 28)
       )
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
}
else
{
    Console.WriteLine(false);
}
/*
Console.WriteLine("Завдання 2");

string number;
int p_index, num11, num22, sum;
char num1, num2;

Console.WriteLine("Введіть дійсне число: ");
number = Console.ReadLine();
//пошук індексу '.' в стрічці
p_index = number.IndexOf("."); 
//пошук першого числа після крапки
num1 = number[++p_index];
//пошук другого числа після крапки
num2 = number[++p_index];
//конвертація з char в sring в int
num11 = int.Parse(num1.ToString());
num22 = int.Parse(num2.ToString());
sum = num11 + num22;
Console.WriteLine("Сума двох чисел: " + sum);

Console.WriteLine("Завдання 3");

string h;
int h2;
Console.WriteLine("Введіть ціле число h: ");
h = Console.ReadLine();
h2 = int.Parse(h);
if ((0 <= h2) & (h2 < 12))
{
    Console.WriteLine("Доброго ранку!");
}
else if ((12<=h2) & (h2 <= 18))
{
    Console.WriteLine("Добрий день!");
}
else
{
    Console.WriteLine("Добрий вечір!");
}

Console.WriteLine("Завдання 4");

int num41, num42, num43, my_max, my_min;
Console.WriteLine("Введіть перше число: ");
num41 = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
num42 = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть третє число: ");
num43 = int.Parse(Console.ReadLine());

my_max = Math.Max(Math.Max(num41,num42), num43);
my_min = Math.Min(Math.Min(num41,num42), num43);
Console.WriteLine("Максимальне число: " + my_max);
Console.WriteLine("Мінімальне число: " + my_min);

Console.WriteLine("Завдання 5");

double length, width, square;
Console.WriteLine("Введіть довжину: ");
length = double.Parse(Console.ReadLine()); 
Console.WriteLine("Введіть ширину: ");
width = double.Parse(Console.ReadLine());
square = length * width;
Console.WriteLine("Площа прямокутника: " + square);
Console.WriteLine("Завдання 6");

int number6;
Console.WriteLine("Введіть число: ");
number6 = int.Parse(Console.ReadLine());
if (number6 % 2 == 0)
    Console.WriteLine("Число є парним");
else
    Console.WriteLine("Число є непарним");
Console.WriteLine("Завдання 7");

int number7, f;
Console.WriteLine("Введіть температуру в градусах Цельсія: ");
number7 = int.Parse(Console.ReadLine());
f = (number7 * 9/5) + 32;
Console.WriteLine("Перетворення в градуси Фаренгейта: " + f);

Console.WriteLine("Завдання 8");
int n, sum8=0;
Console.WriteLine("Введіть число n: ");
n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
    sum8 += i;
Console.WriteLine("Сума = " + sum8);

*/



