using System;
using System.Collections.Generic;

namespace LeetCode.Problems {
    class TwoSumProblem {

        /// <summary>
        /// Return the index of the two numbers that added is equals to the target.
        /// 
        /// Solution: Search for the complement. As you iterate over the array check if you had already 
        /// passed through a number that added to the current number is equal to the target.
        /// 
        /// Create a Dictionary that will store the number value as its key and the number index as its value.
        /// Iterate over the array of numbers and check if the complement of the current number already exists in the Dictionary. 
        /// If not, insert the current number. 
        /// 
        /// Time Complexity: O(n). In the worst case we iterate over the array of numbers only once to find the 2 numbers.
        /// Space Complexity: O(n). In the worst case we store in the dictionary all numbers in the array.
        /// </summary>
        /// <param name="nums">The array of numbers.</param>
        /// <param name="target">The target.</param>
        /// <returns>The index of the two numbers.</returns>
        public int[] TwoSum(int[] nums, int target) {
            var dictionary = new Dictionary<int, int>();
            var twoSum = new int[2];

            for (int i = 0; i < nums.Length; i++) {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement)) {
                    twoSum[0] = dictionary[complement];
                    twoSum[1] = i;
                    break;
                } else if (!dictionary.ContainsKey(nums[i])) {
                    dictionary.Add(nums[i], i);
                }
            }

            return twoSum;
        }
    }
}
