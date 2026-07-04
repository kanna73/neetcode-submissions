public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int result = 0;
        List<int> seq = new List<int>();
        for(int i = 0 ; i<nums.Length-1; i++){
            if(nums[i+1]-nums[i] == 1){
                result = result+1;
            }
            else if(nums[i+1]-nums[i] == 0){
                    continue;
                }
            else{
                seq.Add(result+1);
                result = 0;
                continue;
            }
        }
        seq.Add(result + 1);
        return seq.Max();
        
    }
}
