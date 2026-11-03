Console.WriteLine(MinCostClimbingStairs([10, 15, 20]));

int MinCostClimbingStairs(int[] cost)
{
    //Brute Force
    //return Math.Min(Solve(cost, 0), Solve(cost, 1));

    #region Memoization
    //int[] memo = new int[cost.Length + 1];
    //Array.Fill(memo, -1);

    //return Math.Min(Solve(cost, 0, memo), Solve(cost, 1,memo));
    #endregion Memoization


    #region Tabulation
    int n = cost.Length;

    int[] dp = new int[n + 1];

    dp[0] = cost[0];
    dp[1] = cost[1];

    for (int i = 2; i <= n; i++)
    {
        dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
    }

    return Math.Min(dp[n - 1], dp[n - 2]);
    #endregion Tabulation
}


//Brute Force
//int Solve(int[] cost, int i)
//{
//    int n = cost.Length;

//    if (i >= n)
//        return 0;

//    int res = cost[i];

//    return res + Math.Min(Solve(cost, i + 1), Solve(cost, i + 2));
//}


//Memoization
int Solve(int[] cost, int i, int[] memo)
{
    int n = cost.Length;

    if (i >= n)
        return 0;

    if (memo[i] != -1)
        return memo[i];

    int res = cost[i];

    return memo[i] = res + Math.Min(Solve(cost, i + 1, memo), Solve(cost, i + 2, memo));
}