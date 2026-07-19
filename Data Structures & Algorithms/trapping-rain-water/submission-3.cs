public class Solution {
    public int Trap(int[] height) {
       int count = height.Length;
       int i = 0;
       int j = 1;
       int result =0;
       int temp = 0;

       while(j<count){

        if(height[i]>height[j]){
            if(j==count-1){
                i=i+1;
                j=i+1;
                temp =0;
                continue;
            }
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
