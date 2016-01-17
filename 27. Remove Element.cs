public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        //The major pitsfall: if you naively think just replace the element with the last element will solve this,
        //then you'll find that [2,2] 2 will not be cleaned, because you can never guarantee that the replaced element will not == val.
        //So to solve this, you need to iterate reversely, because only by doing this, you can always guarantee the processed element is never gonna == val.
        
        int length = nums.Length;
        for(int i = length - 1; i >= 0; i--)
        {
            if(nums[i] == val)
            {
                nums[i] = nums[length - 1]; //For the last element of the array, just replace it with itself and shrink the array size.
                length--;
            }
        }
        return length;
    }
}