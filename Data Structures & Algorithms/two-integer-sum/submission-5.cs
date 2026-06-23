public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int count = nums.Length;
        Dictionary<int,int> sum = new Dictionary<int,int>();
        // for(int i = 0; i<count; i++){
        //         sum[nums[i]] = i; // old verson is overwritten
        // }

        // for(int i = 0; i<count;i++){
        //     int diff = target - nums[i];
        //     if(sum.ContainsKey(diff) && i != sum[diff]){
        //         result[0]= i;
        //         result[1]= sum[diff];
        //         break;
        //     }
        // }
        for(int i = count-1; i>=0;i--){
            int diff = target - nums[i];
            if(sum.ContainsKey(diff)){
                result[0]= i;
                result[1]=sum[diff];
                break;
            }
            else{
                sum[nums[i]] = i; // there is difference btw add and this 
            }
        }

        return result;

    }
}
