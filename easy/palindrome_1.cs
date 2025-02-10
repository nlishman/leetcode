public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        string converted = x.ToString();
        for (int i = 0, j = converted.Length - 1; i < j; i++, j--){
                if (converted[i] != converted[j]) return false;
        }
        return true;
    }
}
