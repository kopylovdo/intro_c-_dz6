//  Программа, которая считате сколько чисел больше 0 ввёл пользователь. Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 

Console.Write("Введите количество чисел M ");
int M = Convert.ToInt32(Console.ReadLine());


int count_nums_above_zero = 0;

for (int index = 0; index < M; index++)
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count_nums_above_zero++;
    }
    Console.WriteLine();
}

Console.WriteLine($"Количество чисел больше 0 - {count_nums_above_zero} ");