// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Mass = new int [5,4];

void FillArray(int[,] array) // Заполняем массив рандомными числами. (Метод)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array) // Выводим массив. (Метод)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int RowsSumma(int[,] array)  //  Нахождим строку с минимальной суммой элементов. (Метод)
{
    int row = 0;
    int? min = null;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (min == null) min = sum;
        else if (sum < min)
        {
            min = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i} строки равна: {sum}");
    }
    return row;
}

FillArray(Mass);
PrintArray(Mass);
System.Console.WriteLine();
RowsSumma(Mass);
