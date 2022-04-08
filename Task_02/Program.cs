//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSum(int[,] array)
{
	int minrow = 0;
	int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < array.GetLength(1); j++)
        {
			sum += array[i, j];
        }
		Console.WriteLine($"Сумма чисел в строке {i} равна {sum}");

		if(i == 0)
		minrow = sum;

		else if(sum < minrow)
		{
		minrow = sum;
		minIndex = i;
		}
    }
	Console.WriteLine();
	Console.WriteLine($"Меньшая сумма {minrow}, номер строки {minIndex}");
}

int[,] array = FillArray(5,5);
PrintArray(array);
Console.WriteLine();
MinSum(array);
