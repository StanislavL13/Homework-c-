// Выяснить является ли число чётным
Console.Write("Введите число и нажмите <Enter> ");
int a = Convert.ToInt32(Console.ReadLine());
var message = a % 2 == 0 ? "Число четное" : "Число нечетное";
Console.WriteLine(message);