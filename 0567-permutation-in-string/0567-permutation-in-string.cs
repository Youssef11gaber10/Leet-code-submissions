public class Solution {


    public bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length)
            return false;
        
        // اعمل frequency map لـ s1
        Dictionary<char, int> s1Map = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (s1Map.ContainsKey(c))
                s1Map[c]++;
            else
                s1Map[c] = 1;
        }
        
        // اعمل frequency map للنافذة الأولى
        Dictionary<char, int> windowMap = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
        {
            char c = s2[i];
            if (windowMap.ContainsKey(c))
                windowMap[c]++;
            else
                windowMap[c] = 1;
        }
        
        // قارن النافذة الأولى
        if (AreMapsEqual(s1Map, windowMap))
            return true;
        
        // حرّك النافذة
        for (int i = s1.Length; i < s2.Length; i++)
        {
            // أضف الحرف الجديد (اللي داخل)
            char newChar = s2[i];
            if (windowMap.ContainsKey(newChar))
                windowMap[newChar]++;
            else
                windowMap[newChar] = 1;
            
            // احذف الحرف القديم (اللي خارج)
            char oldChar = s2[i - s1.Length];
            windowMap[oldChar]--;
            if (windowMap[oldChar] == 0)
                windowMap.Remove(oldChar);
            
            // قارن
            if (AreMapsEqual(s1Map, windowMap))
                return true;
        }
        
        return false;
    }
    
    private bool AreMapsEqual(Dictionary<char, int> map1, Dictionary<char, int> map2)
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