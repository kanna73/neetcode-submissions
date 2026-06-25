public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("#",strs);
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        result = s.Split('#').ToList();
        return result;

   }
}
