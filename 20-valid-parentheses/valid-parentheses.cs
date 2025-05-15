public class Solution {
    public bool IsValid(string s) {    
        int Plength;
        do
        {
            Plength = s.Length;
           s = s.Replace("()", "")
             .Replace("{}", "")
             .Replace("[]", "");
             }
             while (s.Length != Plength);
             return s.Length==0;
              }
              }

       