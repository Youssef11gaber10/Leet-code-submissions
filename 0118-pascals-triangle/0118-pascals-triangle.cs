public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        



            IList< IList<int>> pascal_triangle = new List<IList<int>>();
            pascal_triangle.Add(new List<int>() { 1 });


            for (int i = 1; i < numRows; i++)
            {
                //make list
                IList<int> row = new List<int>();
                IList<int> prev_row = new List<int>();

                // add 1 in begin and end
                row.Add(1); 

                //get the prev row and add each two element and added after first 1 added
                prev_row = pascal_triangle[i-1];

                //for loop on prev row  
                for (int j = 0; j < prev_row.Count-1; j++)
                {
                    row.Add(prev_row[j] + prev_row[j+1]);
                }



                
                
                //add 1 in begin and end
                row.Add(1);
                //add row in  trangle
                pascal_triangle.Add(row);

            }

            return pascal_triangle;



        
    }
}