public class Solution {
    public bool IsPowerOfTwo(int n) {
        
        if(n<1)
            return false;
        
        //Smart Solution: only one bit is 1.
        return (n&(n-1))==0;
        
        //Normal Solution: Divide until receive 1.
        while(true)
        {
            if(n == 1)
                return true;
            if(n % 2 == 0)
                n = n / 2;
            else
                return false;
        }
    }
}