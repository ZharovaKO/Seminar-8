// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.WriteLine("Ведите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colums];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив после сортировки: ");

int temp = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++) // Основной цикл который отсчитывает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] > matrix[i, k]) // matrix[0,2] (8) > matrix[0,3] (6)
            {   
                temp = matrix[i, k]; // temp = 6 matrix[0, 3] = 6
                matrix[i, k] = matrix[i, j]; // matrix[0, 3] = 8, matrix[0, 2] = 8
                matrix[i, j] = temp; // matrix[0, 2] = 6
            }
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
