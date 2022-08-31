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

int Prompt(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    int result = int.Parse(text);
    return result;
}

int GetNeededNumber (int[,] matrix)
{
int a = Prompt("Enter a rows number ");
int b = Prompt("Enter a columns number ");
int x = matrix[a-1,b-1];   
if (a>3 && b>4)
{
    Console.Write("This number is not exist ");
}
else
{
    Console.Write($"{x}");
}
return x;
}
GetNeededNumber(matrix);


