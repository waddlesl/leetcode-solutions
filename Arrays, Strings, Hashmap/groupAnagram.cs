public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Use dictionary to store the signature-based value and the list of anagrams
        Dictionary<string, List<string>> anagramsDict = new Dictionary<string, List<string>>();


        for (int i = 0; i < strs.Length; i++) {
            int[] charCount = new int[26];
            // To convert string to a signature array for the key
            foreach (var c in strs[i]) {
                charCount[c - 'a'] += 1;
            }


            // Convert the charCount array to a signature string
            string signature = string.Join(",", charCount);


            // If the signature is not already in the dictionary, initialize an empty list
            if (!anagramsDict.ContainsKey(signature)) {
                anagramsDict[signature] = new List<string>();
            }


            // Add the current string to the corresponding signature group
            anagramsDict[signature].Add(strs[i]);
        }


        // Prepare the result list
        List<IList<string>> anagramsList = new List<IList<string>>();
        foreach (var kvp in anagramsDict) {
            // Add each group of anagrams to the result list
            anagramsList.Add(kvp.Value);
        }


        return anagramsList;
    }
}
