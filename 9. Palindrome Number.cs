public class Solution {
    public bool IsPalindrome(int x) {
        //A Summary of manipulating an integer:
        //  To Extract the digit from right to left: x/10>0 then digit = x%10
        //  To Extract the digit from left to right: get how many digit x has, then digit = x/10^num
        
        if(x<0)
            return false;
        //Get how many digit does x has.
        int num = (int)Math.Floor(Math.Log10(x));
        //Compare each digits from front and end.
        //temp: extract digit from last to first
        //x: extract digit from first to last
        int temp = x;
        for(int i = 0; i <= num/2; i++)
        {
            if(temp % 10 != x / (int)Math.Pow(10, num - i))
                return false;
            else
            {
                temp = temp/10;
                x = x % (int)Math.Pow(10, num - i);
            }
        }
        return true;
        
        //This is how we reverse a integer digit.
        if(x < 0) return false;
        int y = x;
        int res = 0;
        while(y != 0) {
            res = res * 10 + y % 10;
            y /= 10;
        }
        return x == res;
    }
}