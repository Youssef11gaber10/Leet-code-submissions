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
     //finish adj list

     bool[] visited = new bool[numCourses];
     bool[] currPath = new bool[numCourses];
     Stack<int> stack = new Stack<int>();
     int[] topological_sort = new int[numCourses];

     for (int i = 0; i < numCourses; i++)
     {
         if (Dfs(adj, i, stack, visited, currPath) == false)
             return new int[0];
     }

     for (int i = 0; i < numCourses; i++)
     {
         if (stack.Count > 0)
         {
             topological_sort[i] = stack.Pop();
         }
     }

     return topological_sort;

 }//endof func


 bool Dfs(List<List<int>> adj, int node, Stack<int> stack, bool[] visited, bool[] curr_path)
 {
     if (curr_path[node])
         return false;
     if (visited[node])
         return true;

     curr_path[node] = true;
     visited[node] = true;


     foreach(int nei in adj[node])
     {
         if (Dfs(adj, nei, stack, visited, curr_path) == false)
             return false;
     }
     curr_path[node] = false;
     stack.Push(node);
     return true;


 }

}