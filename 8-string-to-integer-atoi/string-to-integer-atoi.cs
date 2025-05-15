public class Solution {
    public int MyAtoi(string s) {
        int i=0;
        int sign=1; 
        long result =0;
        while (i < s.Length && s[i] == ' ')
        {    
            i++;
            }
            if (i==s.Length) return 0;
            if(s[i]=='-')
            {
                sign=-1;
                i++;
            }
            else if(s[i]=='+')
            {
                i++;
            }
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    result = result * 10 + (s[i] - '0');
                    
        
                    if (result * sign < int.MinValue) {return int.MinValue;}
                    else if (result * sign > int.MaxValue){ return int.MaxValue;}
                    i++;
                }
                    return (int)result * sign;
    }
}