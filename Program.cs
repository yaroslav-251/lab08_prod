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
void CountDownWithDepth(int n, int depth) {
    Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");

    if (n == 0)
        return;

    CountDownWithDepth(n - 1, depth + 1);
}
CountDownWithDepth(3, 0);

