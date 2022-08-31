void PrintArray(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
}
void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        matrix[i,j] = matrix[i,j] / 2;
    }
}
}
double[,] matrix = new double[3, 4];

FillArray(matrix);
PrintArray(matrix);
