public class Solution {
        public int SubarraySum(int[] nums, int k)
  {
      int[] prefix_arr = new int[nums.Length];
      prefix_arr[0] = nums[0];
      for (int i = 1; i < nums.Length; i++)
      {
          prefix_arr[i] = prefix_arr[i - 1] + nums[i];
      }
      //after finish this i have array of prefix sum
      Dictionary<int, int> dict = new Dictionary<int, int>();
      dict[0] = 1;
      int count = 0;
      for (int i = 0; i < nums.Length; i++)
      {
          int candidate = prefix_arr[i] - k;
          if (dict.ContainsKey(candidate))
          {
              count += dict[candidate];
          }
          if (dict.ContainsKey(prefix_arr[i]))
          {
              dict[prefix_arr[i]]++;
          }
          else
          {
              dict[prefix_arr[i]] = 1;
          }

      }
      return count;

  }

}