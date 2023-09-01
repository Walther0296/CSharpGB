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
double [,] GenerateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble()*10;
        }
    }
    return array;
}

// Выводим полученный массив на экран
void PrintArray(double [,] array)
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
if ((n<line) || (m<row)) {
    System.Console.WriteLine("Элемент массива с указанными координатами отсутствует");
}
System.Console.Write("{0,6:F2}",array[row-1, line-1]);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Генерируем рандомный массив, задаем параметры массива


