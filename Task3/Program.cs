// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomNumber(int size)
{

    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(0, 10)) + Math.Round(new Random().NextDouble(), 2);

    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] myarray = RandomNumber(size);
ShowArray(myarray);
Max(myarray);
Min(myarray);

double Dif = Max(myarray) - Min(myarray);

Console.WriteLine("Разница между максимум и минимум в массиве равна " + Math.Round(Dif, 2));
