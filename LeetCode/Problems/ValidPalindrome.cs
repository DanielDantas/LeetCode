using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems {
    class ValidPalindrome {
        /// <summary>
        /// Validade if a string is a palindrome.
        /// 
        /// Solution: Two index approuch. Create two indexes 'i' and 'j' starting from the beginning and end of the string respectifuly.
        /// Iterate over the string checking if i' and j' character are valid. If so, check if they are the same. Otherwise, increment the respective index.
        /// If the valid characters are not the same return false (There is no need to continue validating the other characters at this point).
        /// 
        /// Time Complexity: O(n). In the worst case we iterate over the array of numbers only once to find the 2 numbers.
        /// Space Complexity: O(1). Constant. We only store in memory the index values.
        /// </summary>
        /// <param name="s">The string to be validated.</param>
        /// <returns>True, if the string is a palindrome. False, otherwise.</returns>
        public bool IsPalindrome(string s) {
            int i = 0, j = s.Length - 1;

            while (i < s.Length && j >= 0) {

                if (!char.IsLetterOrDigit(s[i])) {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[j])) {
                    j--;
                    continue;
                }
                if (char.ToUpper(s[i]) != char.ToUpper(s[j])) {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
