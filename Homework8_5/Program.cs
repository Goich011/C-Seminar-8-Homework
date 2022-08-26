/*Task 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7     */

void NewMatrix(int[,] matrix)
{
    int temp = 1, i = 0, j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

while (n > m || n < m)
{
    Console.WriteLine();
    Console.WriteLine("Для заполнения матрицы спирально необходимо что бы матрица была с равными сторонами!");
    Console.Write("Введите количество строк: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    m = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[n, m];
Console.WriteLine("Заполненная по спирали матрица: ");
NewMatrix(matrix);
