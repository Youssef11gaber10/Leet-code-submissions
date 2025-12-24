public class Solution {
    Dictionary<int, bool> dp = new Dictionary<int, bool>();

public bool DivisorGame(int n)
{
    dp[1] = false;
    dp[2] = true;
    return Rec(n);
}

bool Rec(int n)
{
    if (dp.ContainsKey(n))
        return dp[n];

    foreach (int x in GetDivisors(n))
    {
        if (!Rec(n - x))
        {
            dp[n] = true;
            return true;
        }
    }

    dp[n] = false;
    return false;
}

List<int> GetDivisors(int n)
{
    List<int> res = new List<int>();
    for (int i = 1; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            if (i < n) res.Add(i);
            if (n / i != i && n / i < n) res.Add(n / i);
        }
    }
    return res;
}
}