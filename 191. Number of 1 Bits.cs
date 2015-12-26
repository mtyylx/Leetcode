public class Solution {
    public int HammingWeight(uint n) {
        //Remember: int range is 31bit: -2^31 to +2^31
        //while:    uint range is 32bit: 0 to +2^32
        
        //Divide By Two, the reminder is the corresponding Binary Bit Value. 
        //So just add up and you will get the Hamming Weight.
        //uint sum = 0;
        //while (n != 0)
        //{
        //    sum = sum + n%2;
        //    n = n/2;
        //}
        //return (int)sum;
        
        //Perform Bit AND one by one until all bit are zero.
        uint sum = 0;
        while (n != 0)
        {
            sum = sum + (n & 1);
            n = n>>1;
        }
        return (int)sum;
    }
}