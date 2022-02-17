// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.WriteLine ("Покажу Вам кубы чисел, заканчивающихся на четную цифру от 1 до N");
Console.WriteLine ("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int a = 0;
for (i = 0; i < (n + 1); i++)
{
     if (i % 2 == 0)
        {
            a = i * i * i;
            Console.WriteLine(a);       
        }
}