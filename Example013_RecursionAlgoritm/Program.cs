﻿string[,] table = new string[2, 5];

// table[0,0]	table[0,1]	table[0,2] ... table[0,4]
// table[1,0]	table[1,1]	table[1,2] ... table[1,4]
// String.Empty - инициализация для строк 

/*
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
	for (int columns = 0; columns < 5; columns++)
	{
		Console.WriteLine($"-{table[rows, columns]}-");
	}
}
*/
//Для чисел
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		Console.Write($"{matrix[i, j]} ");
	}
	Console.WriteLine();
}
*/

/*
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
			matrix[i, j] = new Random().Next(1, 10);
		}
	}
}

int[,] matr = new int[3, 4];
PrintArray(matr);
Console.WriteLine();
FillArray(matr);
PrintArray(matr);
*/

/*
int[,] pic = new int[,]
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,1,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,1,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
{0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)
{
	for (int i = 0; i < image.GetLength(0); i++)
	{
		for (int j = 0; j < image.GetLength(1); j++)
		{
			if (image[i, j] == 0) Console.Write($" ");
			else Console.Write($"+");
		}
		Console.WriteLine();
	}
}

void FillImage(int row, int col)
{
	if (pic[row, col] == 0)
	{
		pic[row, col] = 1;
		FillImage(row - 1, col);    //Рекурсия
		FillImage(row, col - 1);    //Рекурсия
		FillImage(row + 1, col);    //Рекурсия
		FillImage(row, col + 1);    //Рекурсия
	}
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/

/*
double Factorial(int n)
{
	if (n == 1 || n == 0) return 1;
	else return n * Factorial(n - 1);
}
for (int i = 0; i < 40; i++)
	Console.WriteLine($" {i}! = {Factorial(i)}");
*/

// Числа Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
	if (n == 1 || n == 2) return 1;
	else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
	Console.WriteLine($" f({i}) = {Fibonacci(i)}");