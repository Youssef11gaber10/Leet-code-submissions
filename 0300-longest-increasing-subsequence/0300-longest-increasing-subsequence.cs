public class Solution {

         public int LengthOfLIS(int[] nums)
   {
       int[] result = new int[nums.Length];
       result[0] = 1;//base case [10]=1
       
       for (int i = 1; i < nums.Length; i++)
       {
           int max_subseq = 0;
           for (int j = i-1 ; j >= 0; j--)
           {
               //if the numbers before me lesser than me so get the maximum of them and myvalue = the max of them +1
               //and if they bigger skip them
               if(nums[j]< nums[i])//get the biggest sub seq in numbers less than me
               {
                   //max_subseq =Math.Max(nums[j]+1, max_subseq);
                   if (result[j] > max_subseq)
                       max_subseq = result[j];

               }

           }//after finish this loop get the value of num[i] put it in result
           result[i] = max_subseq + 1;
       }

       int max = 1;//to get the max value of the dp at least one element will be 1
       for(int i = 1;i < result.Length; i++)
           if (result[i] > max)
               max = result[i];

       return max;
   }

 
}