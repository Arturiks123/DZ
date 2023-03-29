// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.




int[] array = new int[17];
Random rand = new Random();
for (int x = 0; x < array.Length; x++)
{
    array[x] = rand.Next(100, 1000);

}


int Metod2(int[] array)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            x++;
        }
    }
    return x;
}

int y = Metod2(array);

Console.WriteLine(string.Join(" ", array));

Console.WriteLine("Количество четных чисел = {0}", y);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = new int[3];
Random rand = new Random();
for (int x = 0; x < array.Length; x++)
{
    array[x] = rand.Next(0, 100);

}
int Metod3(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int y = Metod3(array);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Количество нечетных чисел = {0}", y);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


float[] array = new float[5];
Random rand = new Random();
for (int x = 0; x < array.Length; x++)
{
    array[x] = rand.Next(0, 100);

}
float max = array[0];
float min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i]<min)
    {
        min = array[i];
    }
}

Console.WriteLine(string.Join(" ", array));
Console.WriteLine(max-min);
