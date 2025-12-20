public class Solution {
         Dictionary<int, int> dict = new Dictionary<int, int>();
  public int CoinChange(int[] coins, int amount)
  {

      int result = coinchange_internal(coins, amount);
      return result == int.MaxValue ? -1 : result;//just for a specific test case
  }
  int coinchange_internal(int[]coins,int amount)
  {

      if (amount == 0) return 0;

      if (amount < 0) return int.MaxValue;//this is infinity cause when i min( this-return , anything) ignore any negatives

      //check before traverse their childs if i have its value in dp 
      if (dict.ContainsKey(amount))
          return dict[amount];

      int min_coin = int.MaxValue;
      foreach (int coin in coins)
      {
          int result = coinchange_internal(coins, amount - coin);
          if (result < min_coin)//after finish loop of coins have the min coin give me right values
              min_coin = result + 1;
          //minc = Math.Min (minc, CoinChange(coins, amount -coins[i]));
      }
      dict[amount] = min_coin;
      return min_coin;

  }
    

}