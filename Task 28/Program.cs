// Задача 28: Подсчитайте сумму цифр в числе.
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    while (m > 0) 
     {
         b += m % 10;
         m = m / 10;
     }
Console.Write ("Сумма цифр числа = ");
Console.WriteLine (b);