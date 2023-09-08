// Урок 8. Двумерные массивы. Продолжение
int Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// System.Console.WriteLine("Задача №1.");

// int m = Prompt("Количество строк массива ");
// int n = Prompt("Количество столбцов массива ");
// int[,] array = GenerateArray(m, n);
// System.Console.WriteLine("Сгенерированный массив: ");
// PrintArray(array);
// System.Console.WriteLine("Упорядоченный массив:");
// PrintOrderArray(array);

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

// // Выводим сгенерируемый массив
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine("");
//     }
// }

// // Выводим упорядоченный массив
// void PrintOrderArray(int[,] array)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = j + 1; k < n; k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine("");
//     }
// }

// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// System.Console.WriteLine("Задача №2.");

// System.Console.WriteLine("Сгенерированный массив: ");
// PrintArray(array);
// PrintMinRow(array);

// void PrintMinRow(int[,] array)
// {
//     int sum1 = 0;
//     int minRow = 1;
//     for (int i = 0; i < m; i++)
//     {
//         // Считаем суммы элементов во всех рядах. 
//         int sum = 0;
//         for (int j = 0; j < n; j++)
//         {
//             sum += array[i, j];
//         }
//         System.Console.WriteLine($"Сумма элементов строки {i + 1} массива: {sum}");


//         // Будем сравнивать остальные суммы с первой суммой. 
//         if (i == 0)
//         {
//             sum1 = sum;
//         }

//         // Сравниваем. Выявляем номер ряда с минимальной суммой. 
//         if (sum < sum1)
//         {
//             sum1 = sum;
//             minRow = i + 1;
//         }
//     }
//     System.Console.WriteLine($"Минимальная сумма элементов в строках массива: {sum1}, содержится в {minRow} строке. ");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
System.Console.WriteLine("Задача №3.");

Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}







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

Console.WriteLine($"Задание №5.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


