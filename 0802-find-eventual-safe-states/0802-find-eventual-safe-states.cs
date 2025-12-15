public class Solution {
 

 
        List<int> result = new List<int>();
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            int numofnodes = graph.Length;
            List<List<int>> adj = new List<List<int>>();
            for (int i = 0; i < numofnodes; i++)
                adj.Add(new List<int>());

            for (int i = 0; i < numofnodes; i++)
            {

                foreach (int val in graph[i])
                {
                    adj[i].Add(val);
                }
            }
            //finish adjacency list




            //1 have cycle => i mark any one visited but not lead to terminal as 1 cause if it not lead to terminal so it cycle
            //2 its safe node => leads to cycle=> node has no neibours more and all of its neibour don't go to node have 1 => cylce 
            int[] states = new int[numofnodes];



            for (int i = 0; i < numofnodes; i++)
            {
                if (Dfs(adj, i, states) == true)
                {
                    result.Add(i);

                }
            }

            return result;


        }//endoffunc


        bool Dfs(List<List<int>> adj, int node, int[] states)
        {

            if (states[node] == 1)//so it has cycle return false
                return false;

            if (states[node] == 2)
                return true;

            //if pass so its first time to visit
            states[node] = 1;



            foreach (int nei in adj[node])
            {
                if (Dfs(adj, nei, states) == false)//if i met node have state 1 its cycle 
                {
                    return false;//if i have cycle don't continue get back //return false
                }

            }
            //if passed and have not met any node have cyle so this  node is safe added to result(make it 2 and when traverse again will get back to first call and added to result) and make its state 2
            states[node] = 2;
            return true;
        }




}