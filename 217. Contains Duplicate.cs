public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums == null || nums.Length < 2)
            return false;
        
        //The most intuitive solution, has a performance of O(n^2) 
        //for(int i = 1; i < nums.Length; i++)
        //{
        //    for(int j = i - 1; j >= 0; j--)
        //    {
        //        if(nums[j] == nums[i])
        //            return true;
        //    }
        //}
        
        //Same as bucket sort, trade time with space, has a performance of O(n)
        //int max = 0; 
        //int min = 0;
        //for(int i = 0; i < nums.Length; i++)
        //{
        //    if(max < nums[i])
        //        max = nums[i];
        //    if(min > nums[i])
        //        min = nums[i];
        //}
        //int size = max - min + 1;
        //
        //int[] stat = new int[size];
        //
        //for(int i = 0; i < nums.Length; i++)
        //{
        //    stat[nums[i]- min]++;
        //}
        //
        //for(int i = 0; i < stat.Length; i++)
        //{
        //    if(stat[i] > 1)
        //        return true;
        //}
        //
        //return false;
        
        //Use hashtable to calculate the set.
        Hashtable contents = new Hashtable();
        for(int i = 0; i < nums.Length; i++)
        {
            if(contents.ContainsKey(nums[i]))
                return true;
            else
                contents.Add(nums[i], nums[i]);
        }
        return false;
    }
}