public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites)
{
    List<List<int>> adj = new List<List<int>>();
    for (int i = 0; i < numCourses; i++)
        adj.Add(new List<int>());

    foreach (int[] row in prerequisites)
    {
        adj[row[0]].Add(row[1]);//directed
    }
    //finish adj list
    
    bool[] visited = new bool[numCourses];
    bool[] currPath = new bool[numCourses];

    for (int i = 0; i < numCourses; i++)
    {
        if (!visited[i])
        {
            if (DfsFindCycle(adj, i, visited, currPath) == true)//find cycle can't finish 
                return false;

        }
    }
    return true;



}//endof func

bool DfsFindCycle(List<List<int>> adj, int start, bool[] visited, bool[] currPath)
{
    if (visited[start] && currPath[start])//visted and exist in curr path so this is cycle
        return true;
    if (visited[start])//return false from here and continue search or if it finish don't continue
        return false;

    visited[start] = true;
    currPath[start] = true;

    foreach (int nei in adj[start])
    {
       // if (!visited[nei])//i should visit all its neibour even if it was visited before to know if it visited and in curr path
       // {
            if (DfsFindCycle(adj, nei, visited, currPath) == true)//there were cycle return true 
                return true;
       // }
        //finish all its neibour dfs and not found cycle
        //when return from each one you should remove it from curr path 
        //currPath[nei] = false;
    }//end its neibour and no cycle 
    currPath[start] = false;
    return false;

}


}