public class Solution {
    public int TrailingZeroes(int n) {
        //突破口:尾0的来源只能是5和2的积，有多少个5就有多少个0
        //Numbers that contains 2 is much more than numbers that contains 5
        //So there is no need to calculate the factor 2 occurancy.
        int count = 0;
        while(n/5>0)
        {
            count = count + n/5;    //how many numbers that has 5^x factor: n/5, e.g. 20/5 = 4 (5, 10, 15, 20)
            n = n/5;                //for numbers that has more than one 5, e.g. 30/5 + 6/5 = 6 + 1 = 7 (5, 10, 15, 20, 25, 25, 30)
        }
        return count;
        
        
        //This will take too long, complexity O(n) instead of O(logn)
        //for(int i = n; i > 1; i--)
        //{
        //    temp = i;
        //    while(temp%5==0)
        //    {
        //        count5++;
        //        temp = temp/5;
        //    }
        //}
        //return count5;
    }
}