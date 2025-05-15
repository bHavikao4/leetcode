public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       if (strs.Length == 0)
    return " ";
Array.Sort(strs);
string first = strs[0];
string last= strs[strs.Length - 1];
StringBuilder sb = new StringBuilder();
for (int i = 0; i < first.Length; i++)
{
    if (first[i] == last[i])
    {
        sb.Append(first[i]);
    }
    else
    {
        break;
    }
}
    return sb.ToString();
    }
}