public class Solution {
    public int[] PlusOne(int[] digits) {
        //This is good coding, use return smartly to simplify the code.
        //From right to left, find the first non-9 element, ++ then return.
        //And if the for loop is finished without return, then automatically we are sure this is an all nine number.
        for(int idx = digits.Length - 1; idx >= 0; idx--)
        {
            if(digits[idx]!=9)
            {
                digits[idx]++;
                return digits;
            }
            else
                digits[idx] = 0;
        }
        
        int[] newone = new int[digits.Length+1];
        newone[0] = 1;
        return newone;

        //This is bad coding. Too much redundancy.
        //if last digit is not 9, then just change the last digits.
        //if last digit is 9, then add to the previous digit and last digit.
        //if all digit is 9, then shift array right
        int i = 1;
        bool allnine = true;
        for(int x = 0; x < digits.Length; x++)
        {
            if(digits[x]!=9)
                allnine = false;
        }
        if(allnine == true)
        {
            int[] result = new int[digits.Length+1];
            result[0]=1;
            return result;
        }
            
        if(digits[digits.Length - 1] != 9)
        {
            digits[digits.Length - 1]++;
            return digits;
        }
        else
        {
            digits[digits.Length - 1] = 0;
            while(digits[digits.Length - 1 - i]==9)
            {
                digits[digits.Length - 1 - i] = 0;
                i++;
            }
            digits[digits.Length - 1 - i]++;
            return digits;
        }
        
        //or i can just turn the array into one number
        //However this solution cannot handle int array larger than 2147483647!!!
        int sum = 0;
        int ii = 0;
        for(int n = digits.Length - 1; n >= 0; n--)
        {
            sum = sum + digits[n] * (int)Math.Pow(10, ii);
            ii++;
        }
        sum++;
        int len = sum.ToString().Length;
        int[] newarr = new int[len];
        for(int n = len - 1; n >= 0; n--)
        {
            newarr[n] = sum%10;
            sum = sum/10;
        }
        return newarr;
    }
}