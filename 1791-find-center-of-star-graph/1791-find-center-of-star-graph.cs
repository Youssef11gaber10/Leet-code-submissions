public class Solution {
     public int FindCenter(int[][] edges)
 {
     //the center node will be exist in each row 
     //so compare which element of first 4 elem repeated twice and return it
     int a = edges[0][0];//this or the other one may be the center
     int b = edges[0][1];
     if (edges[1][0] == a || edges[1][1] == a)//so the a is the center if matched with another one in second row
         return a;
     //else if (edges[1][0] == b || edges[1][1] == b)
     return b;//the b who will match

 }//end of fuction
}