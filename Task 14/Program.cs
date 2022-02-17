// 14:** Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число");
var n = Console.ReadLine();
if (n.Length > 2)
    {
    n = n.ToString();
    int third = int.Parse(n[2].ToString());
    Console.WriteLine(third);
    }  
else
Console.WriteLine("третьей цифры в числе нет");