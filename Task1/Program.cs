//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomNumber(int size)
{
    
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int Chet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int f = array[i] % 2;
        if(f == 0) sum++;
    }
    return sum;
}

void ShowChet(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowNumber(int sum)
{
    Console.WriteLine("Количество четных чисел " + sum);
}


Console.WriteLine("Введите размер массива.");
int size = Convert.ToInt32(Console.ReadLine());
int[] myarray = RandomNumber(size);
int sum = Chet(myarray);
Chet(myarray);
ShowChet(myarray);
ShowNumber(sum);

