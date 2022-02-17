// 10:** Показать вторую цифру трёхзначного числа.
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
do
            {
                n = n / 10;
                if(n < 100)
                {
                    do
                    {
                        n = n - 10;
                        if (n < 10)
                        {
                            Console.Write("Вторая цифра: ");
                            Console.WriteLine(n);
                        }
                    }
                    while (n > 10);
                }
            }
            while (n > 100);