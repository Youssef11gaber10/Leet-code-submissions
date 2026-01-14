public class Solution {
     public int CountMajoritySubarrays(int[] nums, int target)
   {
       int counter = 0;
       for  (int i = 0; i < nums.Length; i++)
       {
        int countTarget = 0;
           for (int j = i; j < nums.Length; j++)
           {
              if (nums[j] == target)
                   countTarget++;
               int length = j - i + 1;
               if (2 * countTarget > length)
                   counter++;

           }
       }
       return counter;

   }
}