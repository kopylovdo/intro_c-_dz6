// Программа, которая вычисляет сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать

Console.Write("Введите длину массива N ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] numbers = new int[N];
int summa = 0;

Random rnd_number = new Random();
//заполняем массив случайными числами и считаем сумму произведений пар чисел
for (int index = 0; index < N/2; index++)
{
    numbers[index] = rnd_number.Next(1,10);
    numbers[N-index-1] = rnd_number.Next(1,10);
    summa +=  numbers[index]* numbers[N-index-1];
}

//выводим на экран массив
for (int index = 0; index < N; index++)
{
    Console.Write($"{numbers[index]} ");
}
 
// выодим сумму произведений
Console.WriteLine();

Console.WriteLine($"Сумма пар произведений - {summa}");

