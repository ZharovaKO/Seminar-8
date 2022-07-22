// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,\
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

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

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum += matrix[i, j];
//         if (j >= colums)
//         {
//             Console.Write(sum + " ");
//         }
//     }
//     Console.Write(sum + " ");
//     Console.WriteLine(i + "-> строка");
// }
int minimumRow = int.MaxValue;
int numberMinRow = 0;

for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < colums; j++)
        sum += matrix[i, j];

    if (sum < minimumRow)
    {
        minimumRow = sum;
        numberMinRow = i + 1;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов: " + numberMinRow);

 
