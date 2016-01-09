public class Solution {
    public bool IsHappy(int n) {
        //The Key of calculating happy number is the "loop condition".
        //If the number is happy, then during the calculation there will always show up 1.
        //If the number is NOT happy, then there will always a loop of numbers appear in order.
        //This is very important, because if otherwise the numbers appeared are infinite non-repeating, there is no way to exit the loop, thus the algorithm has no time limits.
        
        //Solution 1:
        //One magical observation of the happy pattern is that the number showed up in the sequence will never be number 4.
        //In other words, if 4 appeared in the sequence, then this number must be a unhappy number.
        //This is because 4 will have the following cycling pattern:
        // 4, 16, 37, 58, 89, 145, 42, 20, 4
        //But still I don't get it why ALL unhappy number will always become 4.
        while(n>0)
        {
            int num = 0;
            while(n>0)
            {
                num  = num + (n%10)*(n%10);
                n = n/10;
            }
            n = num;
            
            if(n==4)
                return false;
            if(n==1)
                return true;
        }
        return false;
        
        //Solution 2:
        //Since "the unhappy pattern" is there will be a loop of value, which means there will always be a duplicate value showed up.
        //So we just store every value in the hashmap, and when the new entry is a duplicate value, we can return false.
        Hashtable temp = new Hashtable();
        while(n>0)
        {
            //Return false if the Key is duplicate
            if(!temp.ContainsKey(n))
                //Add the key and its value (the value is not important here)
                temp.Add(n, 0);
            else
                return false;
            
            int num = 0;
            while(n>0)
            {
                num  = num + (n%10)*(n%10);
                n = n/10;
            }
            n = num;
            
            if(n==1)
                return true;
        }
        return false;
    }
}