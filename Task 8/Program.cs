// Показать чётные числа от 1 до N.
Console.WriteLine("Покажу четные числа от 1 до N, введите N");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i += 2) Console.WriteLine(i);