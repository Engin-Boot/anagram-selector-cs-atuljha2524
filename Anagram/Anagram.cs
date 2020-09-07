using System;
using System.Collections.Generic;
using System.Linq

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            //Insert the correct implementation here
            char [] charArray1 = word1.ToCharArray();
            char [] charArray2 = word2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            return Enumerable.SequenceEqual(charArray1, charArray2);
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            for (int i = 0; i < candidates.Count; i++) {
                if (!WordPairIsAnagram(word, candidates[i])) {
                    candidates.RemoveAt(i);
                    i--;
                }
            }
            return candidates;
        }
    }
}
