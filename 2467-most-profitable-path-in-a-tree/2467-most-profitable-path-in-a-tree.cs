public class Solution {
   

 long max_profirt = long.MinValue;

 public int MostProfitablePath(int[][] edges, int bob, int[] amount)
 {

     List<List<int>> adj = new List<List<int>>();
     for (int i = 0; i < amount.Length; i++)
         adj.Add(new List<int>());
     foreach (int[] row in edges)
     {
         adj[row[0]].Add(row[1]);
         adj[row[1]].Add(row[0]);
     }
     //finished the adj list

     bool[] visited = new bool[amount.Length];
     int[] bob_path_time = new int[amount.Length];
     for (int i = 0; i < amount.Length; i++)
         bob_path_time[i] = -1;
     bob_path_time[bob] = 0;
     Dfsbob(adj, bob, 0, bob_path_time, visited);


     int alice_time = 0;
     for (int i = 0; i < amount.Length; i++)//reset visited
         visited[i] = false;
     DfsAlice(adj, 0, alice_time, 0, bob_path_time, visited, amount);


     return (int) max_profirt;




 }//end of func


 bool Dfsbob(List<List<int>> adj, int src, int dest, int[] bob_path_time, bool[] visited)
 {
     if (src == dest) return true;

     visited[src] = true;


     foreach (int nei in adj[src])
     {
         if (!visited[nei])
         {

             bob_path_time[nei] = bob_path_time[src] + 1;
             if (Dfsbob(adj, nei, dest, bob_path_time, visited) == true)//if this return false
                 return true;

             bob_path_time[nei] = -1;//return -1 to neibour i visited if hte path was wrong

         }
     }
     return false;

 }

 void DfsAlice(List<List<int>> adj, int src, int alice_time, int alice_score, int[] bob_path_time, bool[] visited, int[] amount)
 {
     if (visited[src])
     {
         alice_time--;
         return;
     }

     visited[src] = true;
     int nodescore = 0;
     if (bob_path_time[src] == alice_time)
     {
         nodescore = amount[src] / 2;
     }
     else if (bob_path_time[src] == -1 || alice_time < bob_path_time[src])//so alice visted first take its credit
     {
         nodescore = amount[src];
     }//else don't touch alice score
     alice_score += nodescore;


     //i want to check if the node doesn't have neibours it leaf no time to update maxprofit
     bool isleaf = true;
     foreach (int nei in adj[src])
     {
         if (!visited[nei])
         {
             isleaf = false;
             DfsAlice(adj, nei, alice_time + 1, alice_score, bob_path_time, visited, amount);
         }
     }
     if (isleaf == true)//so this update only when get to leaf node
     {
         if(alice_score > max_profirt)
             max_profirt = alice_score;
     }

  
    
     //if the 2 don't have neibours consider it as max profit and decrease the node till nodes still have neibours to continue traverse
  

         



 }





}