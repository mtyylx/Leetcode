public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        //Reverse iterate can be very helpful.
        int idx1 = m - 1;
        int idx2 = n - 1;
        for(int i = m + n - 1; i >= 0; i--)
        {
            //if both array has not reached end, store the bigger element at the tail.
            if(idx1 >= 0 && idx2 >= 0 && nums1[idx1] >= nums2[idx2])
            {
                nums1[i] = nums1[idx1];
                idx1--;
            }
            //if nums1 array reached end but nums2 has not, copy the rest element in nums2 to nums1.
            else if(idx2 >= 0)
            {
                nums1[i] = nums2[idx2];
                idx2--;
            }
            //if nums2 array reached end but nums1 has not, remain nums1 array as it is.
        }
    }
}