// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
//[3 7 22 2 78] -> 76

    double max = 0;
    double min = 0;
Console.WriteLine("Введите размер массива");
double[] array = GetArray(ReadInt());
Console.WriteLine("Ваш массив из случайных чисел: ");
Console.WriteLine(GetArrayAsString(array));

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
             max = array[i];
        min = max;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        
    }
    double diff = max - min;
Console.WriteLine($"Минимальное число массива = {min}: Максимальное число массива = {max}, Разница между ними {diff})");
Console.WriteLine(GetArrayAsString(array));
double[] GetArray(int length) //создаём массив
{
    double[] array = new double[length];//создаём массив
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 100); //заполняем массив
    }

    return array;
}

int ReadInt()//проверка на ввод числа
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
        return i;

    return -1;
}


string GetArrayAsString(double[] array)//выводит символы строки через запятую
{
    string s = string.Empty;

    foreach (double item in array)
    {
        s += $"{item}, ";
    }
    return s;
}


