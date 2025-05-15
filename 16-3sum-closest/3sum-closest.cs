using System;

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int cl= nums[0] + nums[1] + nums[2];

        for (int i = 0; i < nums.Length - 2; i++) {
            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {
                int CS = nums[i] + nums[l] + nums[r];
                if (Math.Abs(target - CS) < Math.Abs(target - cl)) {
                    cl = CS;
                }

                if (CS== target) {
                    return CS; 
                } else if (CS < target) {
                    l++;
                } else {
                    r--;
                }
            }
        }

        return cl;
    }
}
