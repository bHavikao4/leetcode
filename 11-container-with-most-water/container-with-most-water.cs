public class Solution {
    public int MaxArea(int[] height) {
        int start =0;
        int end = height.Length - 1;
        int maxArea =0;
        while (start<end)
        {
            
            int area =Math.Min(height[start],height[end])*(end-start);
            maxArea=Math.Max(area,maxArea);
            if(height[start]<height[end])
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return maxArea;
    }
}