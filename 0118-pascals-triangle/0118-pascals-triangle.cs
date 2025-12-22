public class Solution {
    Dictionary<(int,int), int> memo = new Dictionary<(int,int), int>();
 int pascal_rec(int prev_row, int curr_row)
 {
     if (curr_row == 0 || curr_row == prev_row)//if you at first or at end put 1
         return 1;
     if (memo.ContainsKey((curr_row, prev_row)))//if i count before 1+2 and you record it value gie me sol
        return memo[(curr_row, prev_row)];

     int result_curr = pascal_rec(prev_row - 1, curr_row - 1) + pascal_rec(prev_row - 1, curr_row);
     memo[(curr_row, prev_row)] = result_curr;
     return result_curr;
 }
 public IList<IList<int>> Generate(int numRows)
 {
     IList<IList<int>> triangle = new List<IList<int>>();
     for (int i = 0; i < numRows; i++)
     {
         List<int> row = new List<int>();
         for (int j = 0; j <= i; j++)
         {
             row.Add(pascal_rec(i, j)); //if i=0,j=0 or j=i both return 1 else go inside rec
         }
         triangle.Add(row);
     }
     return triangle;
 }

}