public class Solution {
     public int MinSetSize(int[] arr)
    {
        int target = arr.Length / 2;//this length need to be removed atleaset or more
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
                dict.Add(arr[i], 0);
            dict[arr[i]]++;
        }
        //now i have freq for each element i need to pick maximum occrurnece each time till i staticfy condiiton

        //you can put the elements in priority queue to pick the maximum each time or sort them based on freq

        List<int> frequencies = new List<int>(dict.Values);
        frequencies.Sort((a, b) => b.CompareTo(a));//sort them descending 
        //no need for the keys i the freq represent element if it removed it means element removed
        int count = 0;
        int removed_elements = 0;
        foreach (int freq_elem in  frequencies)
        {
            removed_elements += freq_elem;
            count++;
            if (removed_elements >= target)
                break;
        }

        return count;



    }
}