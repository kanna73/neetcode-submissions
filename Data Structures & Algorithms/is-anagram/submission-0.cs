public class Solution {
    public enum Method{
        Mine,
        ArrayApproach,
        SingleDictionary
    }
        public static bool AreDictionariesEqual<TKey, TValue>(
               Dictionary<TKey, TValue> dict1,
               Dictionary<TKey, TValue> dict2)
        {
            if (dict1.Count != dict2.Count)
                return false;
    
            foreach (var kvp in dict1)
            {
                if (!dict2.TryGetValue(kvp.Key, out var value))
                    return false;
    
                if (!EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                    return false;
            }
    
            return true;
        }
    public bool IsAnagram(string s, string t) {
        var type = Method.Mine;
        var sCount = s.Length;
        var tCount = t.Length;
        bool result=false;
        if (sCount != tCount){
            return false;
        }
        switch(type){
            case Method.Mine:
                 Dictionary<char,int> sfrequency =  new Dictionary<char,int>();
                 Dictionary<char,int> tfrequency =  new Dictionary<char,int>();
                 for(int i = 0; i< sCount; i++){
                     char c = s[i];
                     char d = t[i];
                     if(sfrequency.ContainsKey(c)){
                         ++sfrequency[c];
                     }
                     else{
                         sfrequency.Add(c,1);
                     }
                     if(tfrequency.ContainsKey(d)){
                         ++tfrequency[d];
                     }
                     else{
                         tfrequency.Add(d,1);
                     }
                 }
                 result =  Solution.AreDictionariesEqual(sfrequency,tfrequency);
                 break;
            case Method.ArrayApproach:
                 int[] frequency = new int[26];
                 for(int i = 0; i<sCount; i++){
                    frequency[s[i] - 'a']++;
                    frequency[t[i] - 'a']--;
                 }
                 foreach(var c in frequency){
                    if(c!=0){
                        result = false;
                    }
                 }
                 result = true;
                 break;
            default:
               break;
        }
        return result;

    }
}
