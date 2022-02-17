// 16:** Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if ((n > 0) && (n < 8))
    {
    if ((n > 0) && (n < 6))
        {
        Console.WriteLine("Будний");
        }
    else Console.WriteLine ("Выходной");   
    }
else Console.WriteLine ("Такого дня недели не существует");