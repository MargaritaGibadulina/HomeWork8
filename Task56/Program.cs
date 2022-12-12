/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

int minSumRows = 0;
int sumRows = SumElementsRows(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumRows = SumElementsRows(numbers, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"{minSumRows+1} строкa с наименьшей суммой элементов = {sumRows}");

int SumElementsRows(int[,] numbers, int i)
{
  int sumRows = numbers[i,0];
  for (int j = 1; j < numbers.GetLength(1); j++)
  {
    sumRows += numbers[i,j];
  }
  return sumRows;
}

void FillArrayRandomNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteArray (int[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      Console.Write(numbers[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}