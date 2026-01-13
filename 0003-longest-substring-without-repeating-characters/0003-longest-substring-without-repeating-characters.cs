public class Solution {
  public int LengthOfLongestSubstring(string s)
  {
      
      int start = 0;
      int end = 0;
      int length = 0;
      int max = 0;
      int[] freq = new int[128];
      for (int i = 0; i < freq.Length; i++)
          freq[i] = -1;

      while (end < s.Length)
      {
          

          if (freq[s[end]] != -1)//exist before
          {
              start= Math.Max( start , freq[s[end]] + 1);
              freq[s[end]] = end;
              length = end - start + 1;
              max = Math.Max(max, length);
              end++;
          }
          else//first time 
          {
              freq[ s[end]] = end;
              length++;
              max = Math.Max(max, length);
              end++;
          }
      }
      return max;


  }
}