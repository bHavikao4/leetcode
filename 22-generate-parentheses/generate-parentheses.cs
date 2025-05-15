public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result =new List<string>();
GC(result, "", 0, 0, n);
return result;
void GC(List<string> result, string current, int open, int close, int max)
{
    if (current.Length == max * 2)
    {
        result.Add(current);
        return;
    }
    if (open < max)
    {
        GC(result, current + "(", open + 1, close, max);
    }
    if (close < open)
    {
        GC(result, current + ")", open, close + 1, max);
    }
}
        
    }
}