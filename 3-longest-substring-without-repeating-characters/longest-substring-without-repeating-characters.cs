public class Solution {
    public int LengthOfLongestSubstring(string s) {
     
        int maxlength =0;
        int x = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = x ; j < i ;j++)
            {
                if (s[i] == s[j])
                {
                    x = j + 1;
                    break;
                }
               
            }
            maxlength = Math.Max(maxlength, i-x+1);
        }
        return maxlength;   
    }
}