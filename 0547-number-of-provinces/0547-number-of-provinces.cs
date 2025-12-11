public class Solution {



public int FindCircleNum(int[][] isConnected)
{
    //this graph may be connect and disconnected and most probaly its disconnected 
    //so if the dfs of bfs stopped you must traverse all of its node even if its not connect
    //when some nodes are connected to each other its province
    //so each time start with node not visited yet from dfs/bfs cause its neibour to another city 
    //so it new path so its new provienc (new group of nodes connected to each other)
    //its simmilar to count number of pathes exist in the graph

    int rows  = isConnected.Length;//rows and cols are same here;
    Queue<int> queue = new Queue<int>();
    bool[] visited = new bool[rows];
    int numbers_of_path = 0;
    for (int i = 0; i < rows; i++)//you should traverse all pathes
    {
        if (!visited[i])
        {
            visited[i] = true;
            queue.Enqueue(i);
            numbers_of_path++;
        }
        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            //rows and cols are same you can cols=rows 
            int cols = isConnected[0].Length;
            for(int j = 0;j< cols;j++)
            {
                if (isConnected[node][j] == 1 && !visited[j])
                {
                    visited[j] = true; 
                    queue.Enqueue(j);
                }
            }
        }


    }
    return numbers_of_path;



   

}//end of function









}//end of solution



