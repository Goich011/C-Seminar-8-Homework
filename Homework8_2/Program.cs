/* Task56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  */ 

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


Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Console.WriteLine("Начальная матрица: ");
NewMatrix(matrix);


int[] sumRow = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        sumRow[i] += matrix[i, j];
}
int temp = sumRow[0];
int NumberRow = 1;
for (int i = 0; i < sumRow.Length; i++)
{
    if (sumRow[i] < temp)
    {
        temp = sumRow[i];
        NumberRow = i + 1;
    }
}
Console.WriteLine("Минимальная сумма элементов в строке: " + NumberRow);
Console.WriteLine("Минимальная сумма элементов равна: " + temp);

