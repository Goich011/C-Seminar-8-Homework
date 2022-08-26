/* Task 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2     и     1 5 8 5
5 9 2 3           2 3 4 7
8 4 2 4           4 9 4 2
5 2 6 7           7 2 2 6

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */


void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ProzMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] ResultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(0); j++)
        {
            ResultMatrix[i,j] = matrixOne[i,j] * matrixTwo[i,j];
            Console.Write(ResultMatrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[n, m];
int[,] matrixTwo = new int[n, m];
Console.WriteLine("Начальная матрица 1: ");
NewMatrix(matrixOne);
Console.WriteLine();
Console.WriteLine("Начальная матрица 2: ");
NewMatrix(matrixTwo);
Console.WriteLine();
Console.WriteLine("Произведение дух матриц: ");
ProzMatrix(matrixOne, matrixTwo);

