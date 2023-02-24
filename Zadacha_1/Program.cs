// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Mass = new int [4,4];

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

void Regularize (int [,] array)  //  Сортировка чисел. (Метод)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int l = 0; l < array.GetLength(1)-1; l++)
            {
                if (array[i,l] < array [i,l+1])
                {
                    int temp = array [i,l+1];
                    array [i,l+1] = array[i,l];
                    array[i,l] = temp;
                }
            }
            
        }
    }
}

FillArray(Mass);
PrintArray(Mass);
System.Console.WriteLine();
Regularize(Mass);
PrintArray(Mass);