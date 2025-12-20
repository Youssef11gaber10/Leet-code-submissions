public class Solution {

 public int ClimbStairs(int n)
 {
     List<int> list = new List<int>();
     list.Add(1);//[0]
     list.Add(1);//[1]
     for (int i = 2; i <= n; i++)
     {
         list.Add(list[i - 1] + list[i-2]); //like list[2].add(list[i-1]+list[i+2])
     }

     return list[n];
 }


}