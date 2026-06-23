public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int count = nums.Length;
        Dictionary<int,int> sum = new Dictionary<int,int>();
        for(int i = 0; i<count; i++){
            if(!sum.ContainsKey(i)){
                sum.Add(i,nums[i]);
            } 
        }

        for(int i = 0; i<count;i++){
            int diff = target - sum[i];
            int index = Array.IndexOf(nums, diff);
            if(sum.ContainsKey(index)){
                result[0]= i;
                result[1]= index;
                break;
            }
        }
        return result;

    }
}
