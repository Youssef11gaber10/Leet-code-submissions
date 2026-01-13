public class Solution {
       public int SubarraySum(int[] nums, int k)
      {
          int count = 0;
          for (int i = 0; i < nums.Length; i++)
          {
              int sum = 0;
              for(int j = i; j < nums.Length;  j++)
              {
                  sum += nums[j];
                  if( k == sum)
                  {
                      count++;
                  }
              }
          }
          return count;

      }

}