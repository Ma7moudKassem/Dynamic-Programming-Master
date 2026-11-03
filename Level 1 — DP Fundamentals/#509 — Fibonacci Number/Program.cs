using System.Runtime.InteropServices;

Console.WriteLine(Fib(10));

//Memoization

//int Fib(int n)
//{
//    int[] memo = new int[n + 1];
//    Array.Fill(memo, -1);


//    return Solve(n, memo);
//}


//int Solve(int n, int[] memo)
//{
//    if (n < 2)
//        return n;

//    if (memo[n] != -1)
//        return memo[n];

//    return memo[n] = Solve(n - 2, memo) + Solve(n - 1, memo);
//}


int Fib(int n)
{
    if (n < 2)
        return n;

    int[] dp = new int[n + 1];

    dp[0] = 0;
    dp[1] = 1;

    for (int i = 2; i <= n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }


    return dp[n];
}