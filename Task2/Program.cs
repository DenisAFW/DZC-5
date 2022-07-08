//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomNumber(int size)
{
    
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int SumElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) sum = sum + array[i];
    }
    return sum;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowSum(int sum)
{
    Console.WriteLine("Сумма чисел в нечетных позициях равна " + sum);
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] myarray = RandomNumber(size);
int sum = SumElements(myarray);
SumElements(myarray);
ShowArray(myarray);
ShowSum(sum);