public class Solution {
    public int LengthOfLastWord(string s) {
        
        //This code is shit.
        if(s.Length==0)
            return 0;
        int count = 0;
        bool exist = false;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] != ' ')
            {
                count++;
                exist = true;
            }
            if(exist && s[i] == ' ')
                return count;
        }
        
        if(!exist)
            return 0;
        else
            return count;
    }
}