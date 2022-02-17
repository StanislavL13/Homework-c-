// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран.
int [] arr = new int [8];
Console.Write ("Массив: ");
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = Convert.ToInt32(rand.Next(0,2));
Console.WriteLine (String.Join(", ", arr));