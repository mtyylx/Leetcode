public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        //ASCII code is 8bit in length, so there could only be 256 possible values
        int[] stat1 = new int[256];
        int[] stat2 = new int[256];
        //Same method for Counting and Bucket sort
        for(int i = 0; i< s.Length; i++)
        {
            stat1[s[i]]++;
            stat2[t[i]]++;
        }
        
        for(int i = 0; i < stat1.Length; i++)
        {
            if (stat1[i]!=stat2[i])
                return false;
        }
        
        return true;
        
        //int[] alphabet = new int[26];
        //for (int i = 0; i < s.length(); i++) alphabet[s.charAt(i) - 'a']++;
        //for (int i = 0; i < t.length(); i++) alphabet[t.charAt(i) - 'a']--;
        //for (int i : alphabet) if (i != 0) return false;
        //return true;
    }
}