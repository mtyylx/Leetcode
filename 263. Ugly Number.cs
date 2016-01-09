public class Solution {
    public bool IsUgly(int num) {
        
        //for (int i=2; i<6 && num>0; i++)
        //    while (num % i == 0)
        //        num /= i;
        //return num == 1;
        
        
        //Not Ugly if not positive
        if(num <= 0)
            return false;
        
        //Divide until num does not has factor of 2, 3, 5
        while (true)
        {
            if(num % 2 == 0)
                num = num / 2;
            else if(num % 3 == 0)
                num = num / 3;
            else if(num % 5 == 0)
                num = num / 5;
            else
                break;
        }
        
        //Ugly if num does not has any other factors besides 2, 3, 5 
        if(num > 1)
            return false;
            
        return true;
    }
}