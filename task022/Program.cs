// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.WriteLine("Ведите количество строк первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов первой матрицы: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Важно! Число строк и столбцов первой и второй матрицы должно совпадать");
Console.WriteLine("Ведите количество строк второй матрицы: ");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов второй матрицы: ");
int secondColums = Convert.ToInt32(Console.ReadLine());


if (rows != secondRows && colums != secondColums)
{
    Console.WriteLine("Укажите одинаковое количество столбцов и строк!");
}

int[,] firstMatrix = new int[rows, colums];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        firstMatrix[i, j] = new Random().Next(1, 10);
        Console.Write(firstMatrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] secondMatrix = new int[secondRows, secondColums];
for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        secondMatrix[i, j] = new Random().Next(1, 10);
        Console.Write(secondMatrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] multiplicateMatrix = new int[rows, colums];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        multiplicateMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];

        Console.Write(multiplicateMatrix[i, j] + " ");
    }
    Console.WriteLine();
}



