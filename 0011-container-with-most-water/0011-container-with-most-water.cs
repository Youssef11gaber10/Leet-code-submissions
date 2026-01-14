public class Solution {
   public int MaxArea(int[] height)
 {
     int i=0, j=height.Length - 1;
     int max = 0;
     while (i < j)
     {
         int area = (j - i) * Math.Min(height[i], height[j]);
         max = Math.Max(max, area);
         if(height[i] < height[j])
         {
             i++;
         }
         else
         {
             j--;
         }

     }
     return max;


 }

}