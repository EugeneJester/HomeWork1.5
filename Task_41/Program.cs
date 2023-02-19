//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите количество чисел M, которое вы будете вводить: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
int s = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число N{i + 1}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
    if (n > 0)
        s++;
}

Console.WriteLine($"Количество чисел больше: [{string.Join(", ", array)}] -> {s} ");

