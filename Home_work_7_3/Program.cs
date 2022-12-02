//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(2, 14);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return matrix;
}

double[] GetAverageByColumn(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] avg = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;

        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }

        avg[j] = sum / rows;
    }

    return avg;
}

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[] avg = GetAverageByColumn(GetMatrix(rows, columns));

Console.WriteLine("==============");

for (int i = 0; i < avg.Length; i++)
{
    Console.Write(Math.Round(avg[i] * 100) / 100 + " ");
}
