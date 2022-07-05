// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}

void PrintTwoDimArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArrAvg(int[,] matr)
{
    double[] Sum = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            Sum[j] = Sum[j] + matr[i, j];

        }
        Sum[j] = Sum[j] / matr.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {j} =  {Sum[j]}");

    }

}
/*
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintTwoDimArray(matrix);
ArrAvg(matrix);
*/

// int[,] RandomArray(int m, int n);
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(1, 10);
//         }
//     }
// }



//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
                    }

    }
    return array;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateDoubleArray(M, N);
PrintArray(myArray);

*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintTwoDimArray(matrix);

void FindElement (int i, int j, int[,] matr){
 if (i <= matr.GetLength(0) && j <= matr.GetLength(1))
 {
 Console.WriteLine($"{i}, {j} --> {matr[i, j]}");
 } 
 else{
  Console.WriteLine("Такого элемента не существует");
}
}

Console.Write("Введите номер строки: ");
int I = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int J = Convert.ToInt32(Console.ReadLine());

FindElement(I,J,matrix);

