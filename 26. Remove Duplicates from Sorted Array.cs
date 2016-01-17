public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //Separate corner cases.
        if(nums.Length < 2)
            return nums.Length;
        
        //Use a independent indexer to solve this.
        //To make sure the last element is covered, start idx at 1. Compare i and i-1 instead of i and i+1
        int idx = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                nums[idx] = nums[i];
                idx++;
            }
        }
        
        return idx;
    }
}