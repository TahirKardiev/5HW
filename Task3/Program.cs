void PrintArray(int[,] matrix)
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
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}
}
int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

void GetArithmeticMean (int[,] matrix)
{
    double[] AM = new double [matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
       AM[i]+=matrix[j,i];
    }
    AM[i]/= matrix.GetLength(0);
    Console.Write($"{AM[i]}; ");
}
}

GetArithmeticMean(matrix);
