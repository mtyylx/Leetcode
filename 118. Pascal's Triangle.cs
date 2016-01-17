public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> result = new List<List<int>>();
        
        for(int j = 0; j < numRows; j++)
        {
            //Initialize new row every loop
            List<int> row = new List<int>();
            
            //First element is always 1
            row.Add(1);
            
            //current row (j) element = previous row (j-1) combination.
            for(int i = 0; i < j - 1; i++)
            {
                row.Add(result[j - 1][i] + result[j - 1][i + 1]);
            }
            
            //Last element is always 1, except for row 1
            if(j > 0)
                row.Add(1);
            
            //Store each row
            result.Add(row);
        }
        
        return result;
    }
}