// 12:** Удалить вторую цифру трёхзначного числа.
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
var str = n.ToString();
n = int.Parse(str.Remove(str.Length - 2, 1));
Console.WriteLine(n);