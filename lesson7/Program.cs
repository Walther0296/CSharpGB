// Урок 7. Двумерные массивы

int Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
System.Console.WriteLine("Задача №1.");

int m = Prompt("Количество строк массива ");
int n = Prompt("Количество столбцов массива ");
double[,] array = GenerateArray(m, n);
PrintArray(array);

// Генерируем рандомный массив, задаем параметры массива
double[,] GenerateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

// Выводим полученный массив на экран
void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            System.Console.Write("{0,6:F2}", array[i, j]);
        }
        System.Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Задача №2. Вывод конкретного элемента массива.");
int row = Prompt("Введите номер строки: ");
int line = Prompt("Введите номер столбца: ");
if ((n < line) || (m < row))
{
    System.Console.WriteLine("Элемент массива с указанными координатами отсутствует");
}
System.Console.WriteLine("{0,6:F2}", array[row - 1, line - 1]);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Генерируем рандомный массив, задаем параметры массива

System.Console.WriteLine("Задача №3. Вывод average каждого столбца нового целочисленного массива");

int m1 = Prompt("Количество строк целочисленного массива ");
int n1 = Prompt("Количество столбцов целочисленного массива ");
int[,] array1 = GenerateArrayInt(m1, n1);
PrintArrayInt(array1);
CountAverage(array1);

int[,] GenerateArrayInt(int m1, int n1)
{
    int[,] array1 = new int[m1, n1];
    Random random = new Random();
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            array1[i, j] = random.Next(1, 9);
        }
    }
    return array1;
}
void PrintArrayInt(int[,] array1)
{
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            System.Console.Write(array1[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}

void CountAverage(int[,] array1)
{
    for (int i = 0; i < n1; i++)
    {
        int sum = 0;
        double average = 0;
        for (int j = 0; j < m1; j++)
        {
            sum += array1[j, i];
            average = (double)sum / (double)m1;
        }
        System.Console.WriteLine(
            $"Среднее арифметическое элементов массива столбца {i + 1}: {Math.Round(average, 1)}"
        );
    }
}
