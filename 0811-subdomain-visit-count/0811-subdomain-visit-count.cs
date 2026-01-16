public class Solution {
      public IList<string> SubdomainVisits(string[] cpdomains)
   {

       Dictionary<string, int> map = new Dictionary<string, int>();
       List<string> result = new List<string>();
       for (int i = 0; i < cpdomains.Length; i++)
       {
           string[] content = cpdomains[i].Split(' ');
           int num = int.Parse(content[0]);
           string domain = content[1];

           if (!map.ContainsKey(domain))//fulldomain
               map[domain] = num;

           else
               map[domain] += num;

           for (int j = 0; j < domain.Length; j++)
           {
               if (domain[j] == '.')
               {
                  string dom = domain.Substring(j+1);//if not give length  take till the end
                   if (!map.ContainsKey(dom))
                      map[dom] = num;
                   
                   else
                       map[dom] += num;
               }
           }
       }
       foreach(var pair in map)
       {
           string concat= pair.Value +" "+ pair.Key;
           result.Add(concat);
       }
       return result;

   }



}