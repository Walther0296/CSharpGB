// Урок 9. Рекурсия
int Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Задача №1.");

int N = Prompt("Введите число N: ");
int Ex = 1;
System.Console.Write(NumbersRec(N, Ex));
System.Console.WriteLine("");

string NumbersRec(int N, int Ex)
{
    if (N > Ex)
        return $"{N}, " + NumbersRec(N - 1, Ex);
    else
        return $"{Ex}.";
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Задача №2.");

int M = Prompt("Введите число M: ");
int N1 = Prompt("Введите число N: ");
System.Console.Write(SumRec(M, N1));
System.Console.WriteLine("");

int SumRec(int M, int N1)
{
    if (M > N1)
        return N1 + SumRec(N1 + 1, M);
    else if (M < N1)
        return M + SumRec(M + 1, N1);
    else
        return M;
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
System.Console.WriteLine("Задача №3.");

int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
System.Console.Write(Akkerman(m, n));
System.Console.WriteLine("");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

// Задача с семинара: Напишите программу вычисления результата возведения числа в отрицательную степень
System.Console.WriteLine("Задача №4.");

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число отрицательное число B: ");
System.Console.Write(Result (A, B));

int Power(int A, int B)
{
    if (B == 0)
        return 1;
    else if (B == 1 && A!=0)
        return A;
    else
        return A * Power(A, B - 1);
}

double Result (int A, int B) {
    double res = 1.0 / Power(A, B);
    return (Math.Round(res, B));  
}
