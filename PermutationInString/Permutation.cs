namespace PermutationInString
{
    /// <summary>
    /// A Permutation of a string is another string that contains same characters, only the order of characters can be different.
    /// For example, “abcd” and “dabc” are Permutation of each other.
    /// </summary>
    public static class Permutation
    {

        /// <summary>
        /// 
        /// Method 1 (Use Sorting) 
        ///     1) Sort both strings 
        ///     2) Compare the sorted strings
        ///     
        /// </summary>
        /// <param name="firstString">string 1</param>
        /// <param name="secondString">string 2</param>
        /// <returns>
        /// 
        /// Return true if one of s1's permutations is the substring of s2,
        /// if s2 contains a permutation of s1, or false otherwise
        /// 
        /// </returns>
        public static bool CheckInclusionMethod1(string firstString, string secondString)
        {
            //Here I need to know the lengths of both string
            int firstStringLength = firstString.Length;
            int secondStringLength = secondString.Length;

            //TODO: Validate this
            //// If length of both strings is not same, 
            //// then they cannot be Permutation 
            //if (firstStringLength != secondStringLength)
            //    return false;

            char[] ch1 = firstString.ToCharArray();
            char[] ch2 = secondString.ToCharArray();

            // Sort both strings 
            Array.Sort(ch1);
            Array.Sort(ch2);

            // Compare sorted strings 
            for (int i = 0; i < firstStringLength; i++)
                if (ch1[i] != ch2[i])
                    return false;

            return true;
        }

        /// <summary>
        /// 
        /// Method 2 
        /// Sort the two strings's characters.
        /// Compare the results to see if they're identical.
        /// 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool CheckInclusionMethod2(string str1, string str2)
        {
            //TODO: Validate this
            //if (str1.Length != str2.Length)
            //    return false;

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            return Array.Equals(a, b);
        }
    }
}
