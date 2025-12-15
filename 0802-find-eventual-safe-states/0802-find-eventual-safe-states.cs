public class Solution {
 

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
     bool[] visited = new bool[numofnodes];
     bool[] curr_path = new bool[numofnodes];
     bool[] index_result = new bool[numofnodes];

     for (int i = 0; i < numofnodes; i++)
     {
         if (!visited[i])
         {
             if (Dfs(adj, i, visited, curr_path,index_result) == true)//if the node i start with return with true so put in index result
                 index_result[i] = true;//this node has no cycle get to terminal node
                                        //if return false will skip it

         }
     }


     //after finish just loop on index result from beginnig if have any value with true 
     //put it in list and return it 
     List<int> result = new List<int>();
     for (int i = 0; i < numofnodes; i++)
     {

         if (index_result[i] == true)
             result.Add(i);
     }

     return result;



 }//endoffunc


 bool Dfs(List<List<int>> adj, int node, bool[] visited, bool[] curr_path, bool[] index_result)
 {

     if (curr_path[node])//so it has cycle so skip it remove it from curr path
         return false;

     if (visited[node])
        return index_result[node];

     visited[node] = true;
     curr_path[node] = true;


     foreach (int nei in adj[node])
     {
         if (Dfs(adj, nei, visited, curr_path,  index_result) == false)
         {
             //don't remove them from curr path leave them there cause if some one meet them will consider as cyle even from curr path or from bad nods leads to cycle
             //bad_nodes[node] = true;
             //curr_path[node] = false;//before go remove neibour from curr path//don't remove the bad nodes from curr path
             
             return false;//if i have cycle don't continue get back 
         }

     }
     //if passed and have no cycle so 
     curr_path[node] = false;//if was good nodes remove it from curr path and added to result
     index_result[node] = true;
     return true;
 }



}