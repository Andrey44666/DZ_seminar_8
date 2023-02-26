// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите колличесво полей: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество стольцов: ");
int l = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int[,,] array = Random3dMatrix(n, m, l); 

int[,,] Random3dMatrix( int field, int rows, int columns) // Заполнение матрицы. (Метод)
{
    int[,,] newArray = new int[field, rows, columns];
    for(int i = 0; i < field; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < columns; k++)
            {
                //newArray[i,j,k] = i + j + k;
                newArray[i,j,k] = new Random().Next(10, 99);
            }
        }
    }
    return newArray;
}

void Print3dMatrix(int[,,] matrix)  // Вывода 3d матрицы. (Метод)
{
    for (int i = 0; i < array.GetLength(0); i++) 
   {
        for (int j = 0; j < array.GetLength(1); j++)
       {
           for(int k = 0; k < array.GetLength(2); k++)
           {
            System.Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
           }
           System.Console.WriteLine();
       }
   }
   System.Console.WriteLine();
}

Print3dMatrix(array);