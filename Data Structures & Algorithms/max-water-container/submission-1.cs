public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int j = n-1;
        int i =0;
        int result = 0;
        while(i<j){
            int x1 = i+1;
            int x2 = j+1;
            int mut = x2-x1;
            if(heights[i]>heights[j]){
                result = result < mut*heights[j] ? mut*heights[j] : result;
                j--;
            }
            else if (heights[j]>heights[i]){
                result = result < mut*heights[i] ? mut*heights[i] : result;
                i++;
            }
            else{
                result = result < mut*heights[i] ? mut*heights[i] : result;
                i++;
            }
        }
        return result;
    }
}
