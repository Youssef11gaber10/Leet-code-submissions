public class Solution {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
     {
         List<List<int>> adj = new List<List<int>>();
         for (int i = 0; i < numCourses; i++)
             adj.Add(new List<int>());
         foreach (int[] row in prerequisites)
         {
             adj[row[1]].Add(row[0]);//directed
         }
         //finished adjacecy list

         bool[] visited = new bool[numCourses];
         bool[] curr_path = new bool[numCourses];
         Stack<int> stack = new Stack<int>();
         int[] topological_sort = new int[numCourses];

         for (int i = 0; i < numCourses; i++)//cause if the graph not connected visit all nodes
         {
             if (!visited[i])//if the post dfs ended and there remain dfs not visted => dfs them
             {
                 if (Dfs_postorder(adj, i, visited, curr_path, stack) == false)
                     return new int[0];//this is have cycle can't have topological sort
             }
         }
         //reverse stack
         for (int i = 0; i < numCourses; i++)
         {
             if (stack.Count > 0)
             {
                 topological_sort[i] = stack.Pop();
             }
         }

         return topological_sort;



     }//end of func


     bool Dfs_postorder(List<List<int>> adj, int node, bool[] visited, bool[] curr_path, Stack<int> stack)
     {
         //cause curr_path walk like dfs so i should keep curr path like dfs preorder and also make it visited

         if (visited[node] && curr_path[node])//there cycle in this graph can't do topological sort retun false
             return false;
         if (visited[node])
             return true;//okay don't have cycle continue dfs

         curr_path[node] = true;
         visited[node] = true;

         //first visit neibour after finsih them put node(parent) in stack//this is pre order
         foreach (int nei in adj[node])
         {
             if (Dfs_postorder(adj, nei, visited, curr_path, stack) == false) //from any neibour found cycle
                 return false;
         }
         //second//after finsih neibour 1=> remove it from curr_path 2=> put node(parent) in stack 
         curr_path[node] = false;
         stack.Push(node);
         return true;

     }


}