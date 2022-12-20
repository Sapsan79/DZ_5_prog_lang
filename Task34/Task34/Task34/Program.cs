// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов в массиве со случайными числами: ");

int[] array = GetArray(ReadInt());

Console.WriteLine($"Ваш массив: {GetArrayAsString(array)}");

Console.WriteLine($"Количество чётных цифр в массиве равно {GetEvenNumbers(array)}");

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
int GetEvenNumbers(int[] array) //количество чётных элементов в массиве
{
    int num = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            num ++;
    }

    return num;
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