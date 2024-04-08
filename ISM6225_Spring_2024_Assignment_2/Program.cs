/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                if (nums.Length == 0) // if the number of elements in the array is 0, then it returns the length 0
                {
                    return 0;
                }
                IEnumerable<int> uniqueItems = nums.Distinct<int>(); // Distinct() removes the duplicate elements 
                int n = uniqueItems.Count(); // Here number of elements in the array is assigned to n
                return n;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Self Reflection:
         This C# code counts unique elements in an array `nums` by first checking if the array is empty, returning 0. 
         It then uses `Distinct()` method to remove duplicates, creating a collection of unique elements.
         The final count of these unique elements is calculated with `Count()` and returned.
         The time complexity of this code results in a linear time complexity, O(n), 
         where n is the number of elements in the original array. 
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int nzIndex = 0; // Initialize an index to track non-zero elements

                // Traverse the array
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0) // If the current element is non-zero
                    {
                        // Swap the current non-zero element with the element at nzIndex
                        int temp = nums[nzIndex];
                        nums[nzIndex] = nums[i];
                        nums[i] = temp;

                        nzIndex++; // Increment nonZeroIndex to the next position
                    }
                }
                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Self Reflection:
         * This C# code counts unique elements in an array `nums` by first checking if the array is empty, returning 0. It then uses `Distinct()` method to remove duplicates, creating a collection of unique elements. The final count of these unique elements is calculated with `Count()` and returned.
         Time Complexity: The time complexity of this algorithm is O(n), where n is the number of elements in the array. This is because the algorithm makes a single pass through the array, processing each element exactly once to determine whether it is zero and potentially perform a swap operation.
         Space Complexity: The space complexity is O(1), as the rearrangement of zeros is done in-place with a constant amount of extra space. The only additional memory used is for a few variables (like `nzIndex` and `temp` for swapping), which does not scale with the size of the input array.
 */
        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                IList<IList<int>> result = new List<IList<int>>(); // Initialize the result list to store triplets

                Array.Sort(nums); // Sorting the array 

                for (int i = 0; i < nums.Length - 2; i++) // Iterate through the array, leave space for two other pointers
                {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) // Skip duplicates
                    {
                        int left = i + 1; // Pointer to the element next to nums[i]
                        int right = nums.Length - 1; // Pointer to the end of the array

                        while (left < right) // Two-pointer approach
                        {
                            int sum = nums[i] + nums[left] + nums[right]; // Calculate the sum of the triplet

                            if (sum == 0)
                            {
                                // Found a triplet, add it to the result list
                                result.Add(new List<int> { nums[i], nums[left], nums[right] });

                                // Skip duplicates
                                while (left < right && nums[left] == nums[left + 1])
                                    left++;
                                while (left < right && nums[right] == nums[right - 1])
                                    right--;

                                // Move pointers
                                left++;
                                right--;
                            }
                            else if (sum < 0) // If sum is less than zero, move left pointer to the right
                                left++;
                            else // If sum is greater than zero, move right pointer to the left
                                right--;
                        }
                    }
                }

                return result; // Return the list of triplets
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* Self Reflection :
         * This C# method finds unique triplets in an array that sum to zero by first sorting the array and then applying a two-pointer approach. The sorting helps avoid duplicates, and the two-pointers efficiently find the necessary pairs for each element.
        Time Complexity: O(n^2) due to iterating through the array and using two-pointers for each element.  
        Space Complexity: O(1) or O(n), depending on the sorting algorithm, excluding the output storage.
        
        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int maxConsecutiveOnes = 0; // Initialize variable to store maximum consecutive ones
                int currentConsecutiveOnes = 0; // Initialize variable to store current consecutive ones

                for(int i=0;i<nums.Length;i++) // Iterate through the array
                {
                    if (nums[i] == 1) // If the current element is 1
                    {
                        currentConsecutiveOnes++; // Increment current consecutive ones
                        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes); // Update max consecutive ones if needed
                    }
                    else // If the current element is 0
                    {
                        currentConsecutiveOnes = 0; // Reset current consecutive ones to 0
                    }
                }

                return maxConsecutiveOnes; // Return the maximum consecutive ones
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* 
         * Self Reflection :
         * This C# code calculates the maximum number of consecutive 1s in an array `nums`. This method uses two variables: one to keep track of the current sequence of consecutive 1s and another to record the maximum sequence found. The `Math.Max` function updates the maximum count whenever the current sequence exceeds the previous maximum.
          Time Complexity: O(n), where n is the number of elements in the array. This is due to a single pass through the array, examining each element once.
          Space Complexity: O(1), as the space used does not scale with the input size, only utilizing a fixed number of variables.
         * 
        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int Result = 0;
                int baseMultiplier = 1; // Represents the current power of 2

                while (binary > 0)
                {
                    // Extract the rightmost digit of the binary number
                    int lastDigit = binary % 10;
                    // Update the decimal value with the product of the last digit and the current power of 2
                    Result += lastDigit * baseMultiplier;

                    binary /= 10; // Remove the processed digit 
                    baseMultiplier *= 2; // Update the power of 2
                }

                return Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Self Reflection :
         * This C# function converts a binary number to its decimal equivalent by iterating through each digit of the binary input, starting from the least significant bit. It multiplies each binary digit by its corresponding power of 2 and accumulates this into the result. The base multiplier is doubled at each step to reflect the increasing powers of 2 as we move leftward through the binary number.
           Time Complexity: O(n), where n is the number of digits in the binary number, as the function iterates through each digit once.
           Space Complexity: O(1), using a fixed amount of space for the result and base multiplier, irrespective of the input size.
        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Edge case: if there are less than two elements, the maximum gap is 0.
                if (nums.Length < 2)
                    return 0;

                int maxGap = 0; // Initialize the maximum gap to 0.

                // Initialize minNum and maxNum to the first element of the array.
                int minNum = nums[0];
                int maxNum = nums[0];

                // Find the minimum and maximum values in the array.
                foreach (int num in nums)
                {
                    minNum = Math.Min(minNum, num);
                    maxNum = Math.Max(maxNum, num);
                }

                // Calculate the optimal bucket size to minimize the number of buckets.
                int bucketSize = Math.Max(1, (maxNum - minNum) / (nums.Length - 1));

                // Calculate the number of buckets needed.
                int numBuckets = (maxNum - minNum) / bucketSize + 1; // The "+1" in the denominator prevents division by zero for small arrays.


                // Initialize buckets for storing minimum and maximum values of each bucket.
                int[] minBucket = new int[numBuckets];
                int[] maxBucket = new int[numBuckets];
                bool[] hasValue = new bool[numBuckets]; // A flag to mark non-empty buckets.

                // Distribute the numbers into buckets.
                foreach (int num in nums)
                {
                    int bucketIndex = (num - minNum) / bucketSize; // Calculate the bucket index for the current number.

                    // Update the minimum and maximum values for the current bucket.
                    minBucket[bucketIndex] = hasValue[bucketIndex] ? Math.Min(minBucket[bucketIndex], num) : num;
                    maxBucket[bucketIndex] = hasValue[bucketIndex] ? Math.Max(maxBucket[bucketIndex], num) : num;
                    hasValue[bucketIndex] = true; // Mark the bucket as non-empty.
                }

                // Find the maximum gap by iterating through the buckets.
                int prevMax = minNum; // Initialize prevMax to minNum for the first bucket's minimum calculation.
                for (int i = 0; i < numBuckets; i++)
                {
                    if (hasValue[i]) // Only consider non-empty buckets.
                    {
                        // The maximum gap could be the difference between the minimum of the current bucket and the maximum of the previous bucket.
                        maxGap = Math.Max(maxGap, minBucket[i] - prevMax);
                        prevMax = maxBucket[i]; // Update prevMax to the maximum of the current bucket.
                    }
                }

                return maxGap; // Return the found maximum gap.
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Self Reflection:
         * This C# method computes the maximum gap between elements in a sorted version of the array `nums` using a bucket-sort approach. It finds the min and max values to determine bucket sizes and then distributes elements into these buckets. The maximum gap is identified by comparing the minimum of each bucket with the maximum of the preceding non-empty bucket.
           Time Complexity: O(n), as the method involves linear passes over the input array.
           Space Complexity: O(n), due to the storage for buckets proportional to the input array size.

        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                Array.Sort(nums); // Sort the array in ascending order

                // Traverse the array from right to left to find the largest perimeter
                for (int i = nums.Length - 1; i >= 2; i--)
                {
                    // Check if the current triplet forms a valid triangle (a + b > c)
                    if (nums[i - 2] + nums[i - 1] > nums[i])
                        return nums[i - 2] + nums[i - 1] + nums[i]; // If yes, return the perimeter
                }

                return 0; // If no valid triangle found, return 0
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Self Reflection :
         * This C# code sorts the input array `nums` and iterates backwards to find the largest perimeter of a triangle that can be formed by any three elements. It checks for a valid triangle by ensuring the sum of the two smaller sides is greater than the largest side. If a valid triangle is found, it returns its perimeter; otherwise, it returns 0.
           Time Complexity: O(n log n), due to sorting the array.
           Space Complexity: O(1), as it operates in-place with constant extra space.
        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                while (s.Contains(part)) // Continue the loop until s contains part
                {
                    int index = s.IndexOf(part); // Find the index of the leftmost occurrence of part
                    s = s.Remove(index, part.Length); // Remove part from s starting at the found index
                }

                return s; // Return the modified string after removing all occurrences of part
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* Self Reflection :
         * This C# function iteratively searches and excises every instance of the substring `part` from `s`, continuing until `part` no longer appears in `s`. It locates the initial appearance of `part` in `s`, then employs the `Remove` method to discard this occurrence, repeating the procedure until `s` no longer contains `part`.
           Time Complexity: O(n*m), where n represents the length of `s` and m the count of `part` appearances in `s`, due to the iterative search and index finding.
           Space Complexity: O(n), attributed to the creation of new strings with each removal operation, a consequence of string immutability in C#.

        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}