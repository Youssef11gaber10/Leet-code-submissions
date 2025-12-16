/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node)
 {
     if (node == null) return null;

     Dictionary<Node,Node> dict = new Dictionary<Node,Node>();

    return  Dfs(node, dict);
    
 }

 Node Dfs(Node node, Dictionary<Node,Node> dict)
 {
     if(dict.ContainsKey(node)) //if it have cloned value before return it to be nei to another node don't create new one
         return dict[node];
     //if not so it doesn't have clone make clone for it
     Node clone = new Node();
     clone.val = node.val;
     clone.neighbors = new List<Node>();
     dict[node] = clone;//put it in dict
     foreach(Node nei in node.neighbors)
     {
         clone.neighbors.Add(Dfs(nei, dict));//so when dfs even it was exist in map return cloned or create it and after finish its neibour return it also added as nei to curr node
     }
     return clone;

 }


}