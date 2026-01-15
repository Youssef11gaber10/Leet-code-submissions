public class Solution {
      public bool CheckInclusion(string s1, string s2)
  {
      Dictionary<char,int> map1= new Dictionary<char,int>();
      Dictionary<char,int> map2= new Dictionary<char,int>();

      foreach (char s in  s1)
      {
          if (map1.ContainsKey(s))
              map1[s]++;
          else
              map1[s] = 1;
      }
      //start fixed sliding window
      int start = 0, end = s1.Length - 1;//its fixed to s1.length
      while (end < s2.Length)
      {
          if (!(map1.ContainsKey(s2[start]) && map1.ContainsKey(s2[end])))
          {
              start++;
              end++;
          }
          else
          {
              int it = start;
              while (it <= end)
              {
                  if (map2.ContainsKey(s2[it]))
                      map2[s2[it]]++;
                  else
                      map2[s2[it]] = 1;
                  it++;
              }
              //now check if map1 ,map2 are equals
              bool equals = true;
              foreach(var pair in map2)
              {
                  if (!map1.ContainsKey(pair.Key))
                  {
                      equals = false;
                      break;
                  }
                  if ( map1[pair.Key] != pair.Value)
                  {
                      equals = false;
                      break;
                  }


              }
              if (equals == true)
                  return true;
              else
              {
                  map2.Clear();
                  start++;
                  end++;
              }
          }
      }
      return false;



  }
}