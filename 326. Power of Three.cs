public class Solution {
    public bool IsPowerOfThree(int n) {
        
        double result = Math.Log10(n) / Math.Log10(3);
        if (result != (int) result)
            return false;
        return true;
        
        //Still don't understand why Log10 can get a correct value while Log2 cannot.
        //Seems to be a finite precision problem.
    }
}