public class Solution {
    public bool IsPalindrome(string s) {
        bool result = true;
        string lower = s.ToLower();
        string data  = lower.Replace(" ","");
       // Console.WriteLine(lower.Replace(" ",""));
        int count = data.Length;
        int j = count-1;
        for(int i = 0;i<count;i++){
            if(!char.IsLetterOrDigit(data[i])){
                continue;
            }
            if(!char.IsLetterOrDigit(data[j])){
                j--;
            }
            if( data[i]!=data[j]){
                return false;
            }
            j--;
        }
        return result;
        
    }
}
