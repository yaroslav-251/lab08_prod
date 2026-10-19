// void CountDown(int n) {
//     if (n == 0) {
//         return;
//     }

    
//     CountDown(n - 1);
//     Console.WriteLine(n);
// }
// int b = 100;
// CountDown(b);
// шаг 3
// int SumToN(int n)
// {
//     Console.WriteLine($"Вход: {n}");

//     if (n == 1)
//         return 1;

//     int result = n + SumToN(n - 1);

//     Console.WriteLine($"Выход: {n}, result = {result}");

//     return result;
// }

// Console.WriteLine(SumToN(4));
// шаг 4
// void CountDownWithDepth(int n, int depth) {
//     Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");

//     if (n == 0)
//         return;

//     CountDownWithDepth(n - 1, depth + 1);
// }
// CountDownWithDepth(3, 0);
// часть 4 задача А
// int SumDigits(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     return n % 10 + SumDigits(n / 10);
// }
// Console.WriteLine(SumDigits(4725));
// часть 4 задача В
// int Power(int number, int degree)
// {
//     if (degree == 0)
//     {
//         return 1;
//     }
//     return number * Power(number, degree - 1);
// }
// Console.WriteLine(Power(2, 5));
// итоговая задача

int CountDigits(int n)
{
    if (n < 10)
    {
        return 1;
    }
    return 1 + CountDigits(n / 10);
}
int SumDigits(int n)
{
    if (n < 10)
    {
        return n;
    }
    return n % 10 + SumDigits(n/10);
}
int MaxDigit(int n)
{
    if (n < 10)
    {
        return n;
    }
    int lastDigit = n % 10;
    int maxRest = MaxDigit(n/10);
    if (lastDigit > maxRest)
    {
        return lastDigit;

    }
    else
    {
        return maxRest;
    }
}
void PrintDigits(int n)
{
    if (n < 10)
    {
        Console.Write(n + " ");
        return;
    }
    PrintDigits(n/10);
    Console.Write(n % 10 + " ");
}
Console.Write("Введие положительное число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр: {CountDigits(b)}");
Console.WriteLine($"Сумма цифр: {SumDigits(b)}");
Console.WriteLine($"Максимальная цифра: {MaxDigit(b)}");

Console.Write("Цифры: ");
PrintDigits(b);