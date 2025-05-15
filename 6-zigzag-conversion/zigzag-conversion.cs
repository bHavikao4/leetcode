public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows)
        return s;
    List<StringBuilder> row = new List<StringBuilder>();
    for (int i = 0; i < numRows; i++)
        row.Add(new StringBuilder());
    int cRow = 0;
    bool goingDown = false;
    for (int i = 0; i < s.Length; i++)
    {
        row[cRow].Append(s[i]);
        if (cRow == 0 || cRow == numRows - 1)
            goingDown = !goingDown;
        cRow += goingDown ? 1 : -1;
    }
    StringBuilder result = new StringBuilder();
    {
        foreach (StringBuilder sb in row)
            result.Append(sb.ToString());
            return result.ToString(); 
    }
    
}
}
        
 