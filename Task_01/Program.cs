// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

int[,] FillArray(int row, int column)
{
	int[,] array = new int[row, column];
	Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rnd.Next(0, 20); 
		}
	} 
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]}\t"); 
		}
	Console.WriteLine();
	} 
}

int[,] StreamlineRow(int[,] array)
{
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
	{
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] < array[i, k])
                {
                tmp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = tmp;
                }
            }
        }
    }
    return array;
}

int[,] array = FillArray(5,5);
PrintArray(array);
Console.WriteLine();
StreamlineRow(array);
Console.WriteLine();
PrintArray(array);