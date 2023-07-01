// 66

int GetSumOfRange(int M, int N)
{
     if (M > N)
     return GetSumOfRange(M, N + 1) + N;
     else if (N > M)
     return GetSumOfRange(M + 1, N) + M;
     else
     return M;
}
Console.Write("Введите первое число(M):  ");
int M1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите последнее число(N):  ");
int N1 = Convert.ToInt32(Console.ReadLine());

int sumOfRange = GetSumOfRange(M1, N1);
Console.WriteLine($"Сумма значений ({M1} , {N1}) -> {sumOfRange}");




