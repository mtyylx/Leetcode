public class Solution {
    public int TitleToNumber(string s) {
        int digit = s.Length;
        int sum = 0;
        //A=1, Z=26, no zero
        for (int i = 0; i < digit; i++)
        {
            sum = sum + (s[digit - 1 - i] - 'A' + 1) * (int)Math.Pow(26, i);
        }
        return sum;
    }
}