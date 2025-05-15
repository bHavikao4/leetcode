public class Solution {
    public string LongestPalindrome(string s) {
if (string.IsNullOrEmpty(s) || s.Length < 1)
{
    return "";
}
int x = 0, y = 0;
for (int i = 0; i < s.Length; i++)
{
    int a=lp(s,i, i);
    int b=lp(s, i, i + 1);
    int c = Math.Max(a, b);
    if(c > y - x)
    {
        x = i - (c - 1) / 2;
        y = i + c / 2;
    }
}
return s.Substring(x, y - x + 1);
}


int lp(string s, int i1, int i2)
{
    while (i1 >= 0 && i2 < s.Length && s[i1] == s[i2])
    {
        i1--;
        i2++;
    }
    return i2 - i1 - 1;
}
        
    }
