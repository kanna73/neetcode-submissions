public class Solution {
    public int Trap(int[] height) {
       int count = height.Length;
       int i = 0;
       int j = 1;
       int result =0;
       int temp = 0;

       while(j<count -1){

        if(height[i]>height[j]){
            temp += height[i]-height[j];
            j= j+1;
            continue;
        }
        if(height[j]>=height[i]){
            result += temp;
            temp=0;
            i = j;
            j = j+1;
            continue;
        }
       }
       return result;
    }
}
