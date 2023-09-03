// Урок 8. Двумерные массивы. Продолжение
int Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

System.Console.WriteLine("Задача №1.");

int m = Prompt("Количество строк массива ");
int n = Prompt("Количество столбцов массива ");
int[,] array = GenerateArray(m, n);
System.Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine("Упорядоченный массив:");
PrintOrderArray(array);

// Генерируем рандомный массив, задаем параметры массива
int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 9);
        }
    }
    return array;
}

// Выводим сгенерируемый массив
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}

// Выводим упорядоченный массив
void PrintOrderArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
System.Console.WriteLine("Задача №2.");

System.Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
PrintMinRow(array);

void PrintMinRow(int[,] array)
{
    int sum1 = 0;
    int minRow = 1; 
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        System.Console.WriteLine($"Сумма элементов строки {i + 1} массива: {sum}");

        if (i == 0)
        {
            sum1 = sum;
        }

        if (sum < sum1)
        {
            sum1 = sum;
            minRow = i+1; 
        }
    }
    System.Console.WriteLine(sum1);
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка.");
}













// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
