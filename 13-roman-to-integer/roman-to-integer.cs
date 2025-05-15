public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> romanToInt = new Dictionary<char, int>()
{
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000}
};
int sum = 0;
int prevValue = romanToInt[s[0]];
for (int i = 1; i < s.Length; i++)
{
    int currentValue = romanToInt[s[i]];
    if (currentValue > prevValue)
    {
        sum -= prevValue;
    }
    else
    {
        sum += prevValue;
    }
    prevValue = currentValue;
}
sum+=prevValue;
return sum;
    }
}