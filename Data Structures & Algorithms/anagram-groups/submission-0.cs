public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string ,List<string>> grp = new Dictionary<string,List<string>>();
        foreach(string item in strs){
           char[] ch = item.ToCharArray();
           Array.Sort(ch);

           string key = new string(ch);

           if(grp.ContainsKey(key)){
              grp[key].Add(item);
           }
           else{
            List<string> an = new List<string>();
            an.Add(item);
            grp.Add(key,an);
           }
            
        }
        //groups.Values this will return a ICollection<List<string>> but it looks like this
        // [
        //     ["act", "cat"],
        //     ["pots", "tops", "stop"],
        //     ["hat"]
        // ] 
        //so we want to convert into ICollection<List<string>> to List<List<string>>
        return grp.Values.ToList();
    }
}
