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
   List<int> bad_nodes = new List<int>();
   bool[] index_result = new bool[numofnodes];

   for (int i = 0; i < numofnodes; i++)
   {
foreach (int val in bad_nodes)
    {
     if (i == val)
         continue;
     else
         break;

 }
       for (int j = 0; j < numofnodes; j++)
           visited[j] = false;

       if (!visited[i])
       {
           if (Dfs(adj, i, visited, curr_path, bad_nodes) == true)//if the node i start with return with true so put in index result
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


bool Dfs(List<List<int>> adj, int node, bool[] visited, bool[] curr_path, List<int> bad_nodes)
{

   if (curr_path[node])//so it has cycle so skip it remove it from curr path
       return false;

   if (visited[node])
       return true;

   visited[node] = true;
   curr_path[node] = true;


   foreach (int nei in adj[node])
   {
       if (Dfs(adj, nei, visited, curr_path, bad_nodes) == false)
       {
           bad_nodes.Add(node);
           curr_path[node] = false;//before go remove neibour from curr path
           return false;//if i have cycle don't continue get back 
       }

   }
   //if passed and have no cycle so 
//    visited[node]=false;
   curr_path[node] = false;
   return true;
}




}