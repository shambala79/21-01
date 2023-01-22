// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = GetArray(10, 100, 1000);

Console.WriteLine($"[{String.Join(",", array)}]");

int counteven = 0;

for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
    {
        counteven += 1;
    }

Console.WriteLine($"Чётных чисел в массиве: {counteven}");

// ------Метод------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] Array = Getarray(10);
Console.WriteLine($"[{String.Join(", ", Array)}]");
int sum = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (i % 2 > 0)
    {
        sum = sum + Array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах: {sum}");

// ------Метод------
int[] Getarray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(10);
    }
    return Array;
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] OldArray = Getarray(10);
Console.WriteLine($"[{String.Join(", ", OldArray)}]");
int s = Array.Length / 2;
int k = Array.Length - 1;
int[] NewArray = new int[s];

for (int i = 0; i < s; i++)
{
    NewArray[i]= OldArray[i] * OldArray[k];
    k= k-1;
    }

  Console.WriteLine($"[{String.Join(", ", NewArray)}]");  