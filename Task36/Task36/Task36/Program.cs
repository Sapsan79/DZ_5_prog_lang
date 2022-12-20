// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0
Console.WriteLine("Введите количество элементов в массиве со случайными числами: ");

int[] array = GetArray(ReadInt());

Console.WriteLine($"Ваш массив: {GetArrayAsString(array)}");

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве равна: {GetSummOddNumbers(array)}");

int[] GetArray(int length)
{
    int[] array = new int[length];//создаём массив
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(99, 999); //заполняем массив
    }

    return array;
}
int GetSummOddNumbers(int[] array) //количество чётных элементов в массиве
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ += array[i];
    }

    return summ;
}
int ReadInt()
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
        return i;

    return -1;
}
string GetArrayAsString(int[] array)//выводит символы строки через запятую
{
    string s = string.Empty;

    foreach (var item in array)
    {
        s += $"{item}, ";
    }

    return s;
}