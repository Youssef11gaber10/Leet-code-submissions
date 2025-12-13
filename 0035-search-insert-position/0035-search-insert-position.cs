public class Solution {
    public int SearchInsert(int[] nums, int target) {
           int start = 0;
   int end = nums.Length -1;
   int mid = 0;
   while (start <= end)
   {
       mid = (start + end) / 2;
       if (nums[mid] == target)
           return mid;//the index of target
       else if (nums[mid] < target) //target in more big nums need to go right
       {
           start = mid + 1;
       }
       else if(nums[mid] > target)
       {
           end = mid - 1;
       }
      
   }//end loop
   if (target >nums[mid])
   {
       return mid + 1;
   }
   else 
       return mid;
    }
}