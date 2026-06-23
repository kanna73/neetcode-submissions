public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int count = nums.Length;
        Dictionary<int,int> sum = new Dictionary<int,int>();
        for(int i = 0; i<count; i++){
            if(nums[i]>target){
                continue;
            }
            if(!sum.ContainsKey(nums[i])){
                sum.Add(nums[i],i);
            }
        }

        for(int i = 0; i<count;i++){
            int diff = target - nums[i];
            if(sum.ContainsKey(diff)){
                result[0]= sum[nums[i]];
                result[1]= sum[diff];
                break;
            }
        }
        return result;

    }
}
