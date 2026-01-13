public class Solution {
  public int SubarraySum(int[] nums, int k)
  {
      int prefix_sum = 0;
      Dictionary<int, int> dict = new Dictionary<int, int>();
      dict[0] = 1;
      int count = 0;
      for (int i = 0; i < nums.Length; i++)
      {
          prefix_sum += nums[i];
          int candidate = prefix_sum - k;
          if (dict.ContainsKey(candidate))
          {
              count += dict[candidate];
          }
          if (dict.ContainsKey(prefix_sum))
          {
              dict[prefix_sum]++;
          }
          else
          {
              dict[prefix_sum] = 1;
          }

      }
      return count;

  }

}