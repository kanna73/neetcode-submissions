public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> result = new List<string>();
        while(i<s.Length){
            int j = i;
            while(s[j]!= '#'){
                j++;
            }

            int wordLength = int.Parse(s.Substring(i,j-i));
            string word = s.Substring(j+1,wordLength);
            i = j+1+wordLength;
            result.Add(word);
        }
        return result;
            
        

   }
}
