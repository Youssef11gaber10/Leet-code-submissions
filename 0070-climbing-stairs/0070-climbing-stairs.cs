public class Solution {

      Dictionary<int, int> dict = new Dictionary<int, int>();
      public int ClimbStairs(int n)
      {
          if (n <= 1)
              return 1;
          if(dict.ContainsKey(n)) //dict exist
          {
              return dict[n];
          }//if not exist i should preserve its value after compute it
          int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
          dict[n] = result;//preserve its value
          return result;
      }
}