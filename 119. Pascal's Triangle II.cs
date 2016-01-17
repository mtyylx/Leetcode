public class Solution {
    public List<int> GetRow(int rowIndex) {
        List<int> result = new List<int>();
        
        //Solution 1: First append 1, then sum from end - 1 to start.
        result.Add(1);
        for(int j = 0; j < rowIndex; j++)
        {
            result.Add(1);
            int start = result.Count - 2;
            for(int i = start; i > 0 && j > 0; i--)
            {
                result[i] = result[i] + result[i - 1];
            }
        }
        return result;
        
        //Solution 2: This used 2k+1 extra space
        //for(int j = 0; j < rowIndex + 1; j++)
        //{
        //    List<int> current = new List<int>();
        //    current.Add(1);
        //    for(int i = 0; i < j - 1; i++)
        //    {
        //        current.Add(result[i] + result[i + 1]);
        //    }
        //    if(j > 0)
        //        current.Add(1);
        //    result = current;
        //}
        //return result;
    }
}