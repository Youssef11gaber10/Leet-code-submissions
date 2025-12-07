public class Solution {
         public int FindJudge(int n, int[][] trust)
      {
          //if example with  n = 3, trust = [[1,3],[2,3]]
          int[]freq = new int[n+1]; //to track the values of n =1,2,3 at => [0]empty,[1],[2],[3]

          foreach(int[] row in trust)
          {
              int outval =row[0];//col [0] its outbound decrease its value in freq
              int inval = row[1];//col[1] its inbound  increase its value in freq

              freq[outval]--;
              freq[inval]++;//so 3 most inbound maxibound = n-1(3itself) = 2 no outval to [3] to decrease it so if it decreased with inbound will be < maxinbound

          }
          int maxbound = n - 1;

          for(int i = 1; i <= n; i++) //starts from 1 to skip [0] cause range of number starts from 1
          {
              if (freq[i] == maxbound )
                  return i;
          }
          return -1;

      }
}