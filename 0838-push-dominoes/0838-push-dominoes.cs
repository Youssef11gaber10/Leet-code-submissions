public class Solution {
       public string PushDominoes(string dominoes)
    {
       
            char[] arr = dominoes.ToCharArray();
            int n = arr.Length;
            int last_L = -1, last_R = -1;

            for (int pos = 0; pos < n; pos++)
            {
                if (arr[pos] == 'L')
                {
                    if (last_R > last_L)
                    {
                     
                        int left = last_R;
                        int right = pos;
                        while (left < right)
                        {
                            arr[left++] = 'R';
                            arr[right--] = 'L';
                        }
                    }
                    else
                    {
                      
                        int start = last_L + 1;
                        while (start <= pos)
                        {
                            arr[start++] = 'L';
                        }
                    }
                    last_L = pos;
                }
                else if (arr[pos] == 'R')
                {
                    if (last_R > last_L)
                    {
                        int start = last_R;
                        while (start < pos)
                        {
                            arr[start++] = 'R';
                        }
                    }
                    last_R = pos;
                }
            }

            if (last_R > last_L)
            {
                int start = last_R;
                while (start < n)
                {
                    arr[start++] = 'R';
                }
            }

            return new string(arr);
        

    }
}