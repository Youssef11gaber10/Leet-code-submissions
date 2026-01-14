public class Solution {
  public int MaximizeExpressionOfThree(int[] nums)
 {
     int max1 = int.MinValue;
     int max2 = int.MinValue;
     int min = int.MaxValue;
     foreach ( int n in nums )
     {
         if ( n > max1 )
         {
             max2 = max1;
             max1 = n;
         }
         else if(n> max2)
         {
             max2 = n;
         }

        if(n < min) 
         {
             min = n;
         }
     }
     return max1+max2-min;

 }
}