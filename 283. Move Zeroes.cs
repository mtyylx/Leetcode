public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums!= null)
        {
            //Find out how many zeros are there
            int count = 0;
            for(int i = 0; i< nums.Length; i++)
            {
                if(nums[i]==0)
                    count++;
            }
            
            //Copy the non-zero element to the front
            int idx = 0;
            for(int i = 0; i< nums.Length; i++)
            {
                if(nums[i]!=0)
                {
                    nums[idx] = nums[i];
                    idx++;
                }
            }
            
            //add as many as 'count' zeros at the end
            for(int i = nums.Length - 1; i >= nums.Length - count; i--)
            {
                nums[i] = 0;
            }
        }
    }
}