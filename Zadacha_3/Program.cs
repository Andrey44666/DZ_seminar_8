// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MassA = new int [2,2];
int[,] MassB = new int [2,2];

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

int[,] Multiplication(int[,] matrixA, int[,] matrixB)  // Умножение матриц. (Метод)
{ 
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

System.Console.WriteLine("Первая матрица: ");
FillArray(MassA);
PrintArray(MassA);
System.Console.WriteLine("Вторая матрица: ");
FillArray(MassB);
PrintArray(MassB);
System.Console.WriteLine("Результат умножения двух матриц: ");
Multiplication(MassA,MassB);
PrintArray(Multiplication(MassA,MassB));