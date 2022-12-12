/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int a = ReadInt("Введите число строк 1-й матрицы: ");
int b = ReadInt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int c = ReadInt("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = new int[a, b];
FillMatrixRandomNumbers(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteMatrix(firstMartrix);

int[,] secondMatrix = new int[b, c];
FillMatrixRandomNumbers(secondMatrix);
Console.WriteLine($"Вторая матрица:");
WriteMatrix(secondMatrix);

int[,] resultMatrix = new int[a, c];

MultiplicationMatrix(firstMartrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteMatrix(resultMatrix);

void MultiplicationMatrix(int[,] firstMartrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void FillMatrixRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}