public class Solution {

    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        Dictionary<char, int> map1 = new Dictionary<char, int>();
        
        foreach (char c in s1)
        {
            if (map1.ContainsKey(c))
                map1[c]++;
            else
                map1[c] = 1;
        }
        
        int windowSize = s1.Length;
        
        for (int i = 0; i <= s2.Length - windowSize; i++)
        {
            Dictionary<char, int> map2 = new Dictionary<char, int>();
            
            for (int j = i; j < i + windowSize; j++)
            {
                char c = s2[j];
                if (map2.ContainsKey(c))
                    map2[c]++;
                else
                    map2[c] = 1;
            }
            
            if (AreDictionariesEqual(map1, map2))
                return true;
        }
        
        return false;
    }
    
    private bool AreDictionariesEqual(Dictionary<char, int> map1, Dictionary<char, int> map2)
    {
        if (map1.Count != map2.Count)
            return false;
        
        foreach (var pair in map1)
        {
            if (!map2.TryGetValue(pair.Key, out int value) || value != pair.Value)
                return false;
        }
        
        return true;
    }

}