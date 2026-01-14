public class Solution {

          public int TotalFruit(int[] fruits)
        {
            int length = 1;
            int start = 0;
            int end = 0;
            int max = 0;
           
            Dictionary<int,int> dict = new Dictionary<int,int>();
            while(end  < fruits.Length)
            {
                
                if ( dict.Count<2 && !dict.ContainsKey(fruits[end]))
                {
                    dict[fruits[end]] =1;
                }
                else if ( dict.ContainsKey(fruits[end]) )
                {
                    dict[fruits[end]]++;
                }
                else if(dict.Count == 2 && !dict.ContainsKey(fruits[end]) )//this subtitution
                {
                    // i will move start and update map if element reach to 0 freq i will remove it
                    while (start < end)
                    {
                        if (dict[ fruits[start] ] == 1)//i will remove this element and break loop
                        {
                            dict.Remove(fruits[start]);
                            start++;//at the end 
                            break;
                        }
                        dict[fruits[start]]--;
                        start++;
                    }
                    dict[fruits[end]] = 1;
                    length = end - start + 1;
                }
                max = Math.Max(max, length);
                end++;
                length++;

            }
            return max;

        }

}