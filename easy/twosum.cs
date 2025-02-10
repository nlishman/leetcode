public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];

        for(int i = 0; i < nums.Length; i++){
            int rhs = target - nums[i];
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[j] == rhs)
                {
                    result[0] = i; result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}
