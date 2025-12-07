public class Solution {
      public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        //1=> 2,3
        //2=> 3,1
        //3=> 1
        //map 2d array to adjacency list
        List<List<int>> adj = new List<List<int>>();
        for (int i = 0; i < n; i++)//n is number of unique elements he gives you at first n = 0 to n-1
        {
            adj.Add(new List<int>());//make each n in n =0,1,2,3 have list
        }

        foreach (int[] row in edges)
        {
            int u = row[0];
            int v = row[1];
            //this undirected graph so make u=>v and v=>u

            //u will be [0]=> n=0 so put  its neibours row[1] =1 like you say row[0] -> row[1]
            adj[u].Add(v);//so this add in adj[u] for ex adj[1].add([2]) [1,2]
            adj[v].Add(u);//and the opposite adj[2].add([1]) [2,1]


        }

        //now we have the adjacency list so we will do the dfs

        bool[]visited = new bool[n];//of the n = 0 -> n-1

        return Dfs(source, destination, adj, visited) == true ;

    }//end of function

    bool Dfs(int node, int dest, List<List<int>> adj, bool[] visited)
    {
        if(node == dest) return true;

        //if (visited[node]==true) return true;


        visited[node] = true;

        foreach ( int neibour in adj[node])
        {
            if (visited[neibour] == false)//not visted before if visted don't do the dfs
            {
                if (Dfs(neibour, dest, adj, visited) == true)//check if this dfs reach dst and return true return true don't continue
                    return true;
            }
        }

        return false;


    }

}