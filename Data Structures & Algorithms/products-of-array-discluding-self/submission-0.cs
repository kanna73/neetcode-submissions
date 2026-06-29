public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int count = nums.Length;
        int[] left = new int[count];
        int[] right = new int[count];
        int[] result = new int[count];
         left[0] = 1;
        for(int i= 1; i<count;i++){
            left[i] = left[i-1] * nums[i-1];
        }
        right[count-1] = 1;
        for(int j = count-2; j>=0;j--){
            right[j] = right[j+1]*nums[j+1];
        }
        for (int i =0; i<count; i++){
            result[i]= left[i]*right[i];
        }
        return result;
        
    }
}
