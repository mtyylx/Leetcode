public class Solution {
    public int MajorityElement(int[] nums) {
        //This question does not test arrays that don't have a majority element. e.g. [1 1 2 2]
        //The majority element here will always appear MORE THAN n/2 time. (Not >= but >)
        //Array.Sort(nums);
        //return nums[nums.Length/2];
        
        int major = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                count++;
                major = nums[i];
            }
            else if (major == nums[i])
                count++;
            else
                count--;
        }
        
        return major;
    }
}