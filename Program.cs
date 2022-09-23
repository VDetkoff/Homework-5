
// Домашняя работа 1  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArrey(int size)
{
    int [] newArrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(100, 999 + 1);
    }
    return newArrey;
}
void ShowArrey(int [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i] }, ");
    Console.Write("\b\b]");
    Console.WriteLine();
   
}


int FindSum(int[] arrey)
{
    int sum = 0;
    
    for(int i = 0; i < arrey.Length; i++)
        if(arrey[i] % 2 == 0) sum++;

    return sum;    
}

Console.Write("Input size of arrey: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] newArrey = CreateRandomArrey(size);
ShowArrey(newArrey);
Console.Write($"Sum positive elements is {FindSum(newArrey)}");
*/

// Домашняя работа 2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArrey(int size, int minValue, int maxValue)
{
    int [] newArrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArrey;
}
void ShowArrey(int [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i] }, ");
    Console.Write("\b\b]");
    Console.WriteLine();
   
}


int FindSum(int[] arrey)
{
    int sum = 0;
    
    for(int i = 1; i < arrey.Length; i += 2)
        
    sum += arrey[i];

    return sum;    
}

Console.Write("Input size of arrey: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers 1: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers 2: ");
int max = Convert.ToInt32(Console.ReadLine());



int[] newArrey = CreateRandomArrey(size, min, max);
ShowArrey(newArrey);
Console.Write($"Sum positive elements is {FindSum(newArrey)}");
*/