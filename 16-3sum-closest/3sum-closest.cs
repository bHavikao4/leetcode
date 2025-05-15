using System;

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closestSum = nums[0] + nums[1] + nums[2]; // Initialize with first 3 elements

        for (int i = 0; i < nums.Length - 2; i++) {
            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {
                int currentSum = nums[i] + nums[l] + nums[r];

                // Check if this sum is closer to target
                if (Math.Abs(target - currentSum) < Math.Abs(target - closestSum)) {
                    closestSum = currentSum;
                }

                if (currentSum == target) {
                    return currentSum; // exact match
                } else if (currentSum < target) {
                    l++;
                } else {
                    r--;
                }
            }
        }

        return closestSum;
    }
}
