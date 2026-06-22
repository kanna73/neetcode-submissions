
public class Solution {
    public enum method{
        BruteForce,
        HashMap,
        Sort
    }
    public bool hasDuplicate(int[] nums) {
        var type = method.Sort;
        if(type == method.BruteForce)
        {
             Dictionary<int,int> duplicate =  new Dictionary<int,int>();
            foreach(var i in nums)
            {
            if(duplicate.ContainsKey(i))
            {
                return true;
            }
            else{
                duplicate.Add(i,1);
            }
            }
            return false;
        }
        else if(type == method.HashMap){
        for(int i = 0; i<nums.Length; i++){
            for(int j = i+1; j<nums.Length; j++){
                if(nums[i] == nums[j]){
                    return true;
                }
            }
        }
        return false;
        }
        else{
            Array.Sort(nums);
            foreach(var k in nums){
            Console.WriteLine(k);
            }
            for(int m = 0;m<nums.Length-1; m++){
                if(nums[m] == nums[m+1]){
                    return true;
                }
            }
            return false;
        }
             
    }
}