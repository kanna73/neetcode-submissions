public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> fre = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length;i++){
            if(!fre.ContainsKey(nums[i])){
                fre.Add(nums[i],1);
            }
            else{
                fre[nums[i]]++;
            }
        }
       return fre.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        
    }
}
