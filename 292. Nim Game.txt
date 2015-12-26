public class Solution {
    public bool CanWinNim(int n) {
        //You will never win if there are 4*x stone left (by start or by your opponent) for you
        if(n%4==0)
            return false;
        else
            return true;
    }
}