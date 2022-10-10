// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int size = new Random().Next(1,11);

int[] CreateArr(int size)
{
    return new int[size];
}

void FillArr(int[] array)
{
    int size = array.Length;
    for(int i =0; i < size; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
}

void PrintArr(int[] array)
{
    int size = array.Length;
    for(int i =0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int FindCount (int[] array)
{
    int size = array.Length;
    int count = 0;
    for(int i =0; i < size; i++)
    {
        if(array[i]>0) count++;
    }
    return count;
}

int[] numlen = CreateArr(size);
FillArr(numlen);
PrintArr(numlen);
Console.WriteLine();
Console.WriteLine($"positive numbers = {FindCount(numlen)}");