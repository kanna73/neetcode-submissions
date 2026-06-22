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
        var type = Method.SingleDictionary;
        var sCount = s.Length;
        var tCount = t.Length;
        bool result = false;
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
                 return Solution.AreDictionariesEqual(sfrequency,tfrequency);
            case Method.ArrayApproach:
                 int[] frequency = new int[26];
                 for(int i = 0; i<sCount; i++){
                    frequency[s[i] - 'a']++;
                    frequency[t[i] - 'a']--;
                 }
                 foreach(var c in frequency){
                    if(c!=0){
                        return false;
                    }
                 }
                 return  true;
            default:
               Dictionary<char, int> f =  new Dictionary<char,int>();
               for(int i = 0; i<sCount; i++){
                f[s[i]] = f.GetValueOrDefault(s[i],0)+1;
               }
               for(int i = 0; i< sCount; i++){
                  if(!f.ContainsKey(t[i])){
                    return false;
                  }
                  f[t[i]]--;

                  if(f[t[i]] == 0){
                    f.Remove(t[i]);
                  }
               }
               return f.Count == 0;
        }
        return result;

    }
}
