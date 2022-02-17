// Найти максимальное из трёх чисел.
Console.Write("Введите три числа, после ввода каждого числа - нажмите <Enter> ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a) 
    max = b;
if (c > b)
    max = c;    
    Console.Write("Наибольшее число ");
    Console.WriteLine(max);
    