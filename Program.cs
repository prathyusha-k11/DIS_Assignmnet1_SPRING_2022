/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                //Logic Explaination
                // In this method i am taking the list of vowels into a character array and iterating through each of those 
                // vowels to check if they are present at any of the indices in the actual string . If present, removing that
                // letter from that particular index location and incremented it to see if more such index locations are present and 
                // removing all of the vowels similarly. Handled the corner case of only vowels being there in the string by returning 
                // an empty string in that case. It also handles corner case of case sensitive output for a given input.
                // write your code here
                char[] arr = { 'a', 'e', 'i', 'o', 'u' };
                foreach (char c in arr)
                {
                    int idx = s.ToLower().IndexOf(c);

                    while (idx >= 0)
                    {
                        if (s.Length <= 1)
                        {
                            s = "";
                            break;
                        }
                        else
                        {
                            s = s.Remove(idx, 1);
                            idx = s.ToLower().IndexOf(c, idx + 1);
                        }

                    }

                }
                String final_string = s;
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //Logic Explaination
                // In this method i am using join function to join all the parts of the array into a single string first,
                // for each of the string arrays and then comparing them if they are equal to return true else return false.
                // write your code here.
                string s = string.Join("", bulls_string1);
                string v = string.Join("", bulls_string2);
                if (s.Equals(v))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //Logic Explaination
                // In this method i am first iterating the bull bucks array to add the elements one by one to new array while checking if
                // the current element being added is already present in the array or not. If it is already present, i am removing
                // the element present at that index by initiating it to 0 so that the sum is not effected by duplicate values. If it is 
                // not present i am adding it to new array. Finally calculating the sum of all elements in the new array to get sum of unique
                // values
                // write your code here
                int[] arr = new int[100];
                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    int e = bull_bucks[i];
                    if (arr.Length != 0)
                    {
                        int idx = Array.IndexOf(arr, e);
                        if (idx != -1)
                        {
                            arr[idx] = 0;
                        }
                        else
                        {
                            arr[i] = e;
                        }
                    }
                    else
                    {
                        arr[i] = e;
                    }

                }
                int s = 0;
                for (int i = 0; i < 100; i++)
                {
                    s = s + arr[i];
                }
                return s;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                //Logic Explaination
                // In this method i am iterating the given 2 dimensional array over each element in each row and column and only adding up 
                // the elements that are present at indices where i=j  or i+j = total length -1 which are nothing but the diagonal elements
                // additionally i am using pass boolean array to identify and pass the elements that are already added to the sum(like the center element
                // in an odd*odd array) in order not to add the common element of both the diagonals twice.
                // write your code here.
                int sum = 0;
                bool[,] pass = new bool[bulls_grid.GetLength(0), bulls_grid.GetLength(1)];
                for (int i = 0; i < bulls_grid.GetLength(0); i++)
                {
                    for (int j = 0; j < bulls_grid.GetLength(1); j++)
                    {
                        if (pass[i, j])
                        {
                            continue;
                        }
                        else
                        {
                            if ((i == j) || (i + j) == (bulls_grid.GetLength(0) - 1))
                            {
                                sum += bulls_grid[i, j];
                            }
                        }
                    }
                }

                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //Logic Explaination
                // In this method i am using a simple method of adding the elements at the given index locations from bull string array
                // to a new array at the positions indicated by the indices in the indices array respectively. Returning this new char array
                // as a string for output
                // write your code here.
                int l = bulls_string.Length;
                char[] n = bulls_string.ToCharArray();
                char[] arr = new char[l];

                for (int i = 0; i < l; i++)
                {

                    arr[indices[i]] = n[i];

                }
                return new string(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //Logic Explaination
                // In this method i am first finding the first instance of the given character in the array and returning its index,
                // using which i am splitting the bulls string6 into two parts. Reversing the first part of string and saving it in another
                // string to which i am concatenating the remaining portion of the main string stored in part2 substring.
                String prefix_string = "";
                int idx = bulls_string6.IndexOf(ch);
                if (idx > 0)
                {
                    string part1 = bulls_string6.Substring(0, idx + 1);
                    string part2 = bulls_string6.Substring(idx + 1);
                    for (int i = part1.Length - 1; i >= 0; i--)
                    {
                        prefix_string += part1[i];
                    }
                    prefix_string += part2;
                }
                else
                {
                    prefix_string = bulls_string6;
                }

                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

//Self Reflection
//Question 1
// In this question i have learnt how to efficiently use methods like tolower, remove, indexof to reduce the time and space complexity 
// and efficiently bring out a solution instead of traditional iteration approach. It took me 15 minutes for this question as the complexity 
// level was not too high.
//Question 2
// This question did not take much time for me as soon as i figured out the logic of first combining the parts and then comparing. It took 7 min.
//Question 3
// This question needed time to explore the ways to find out unique elements. I tried to see if there are any inbuilt functions like distinct 
// or unique but couldn't find one in c#. So i proceeded to use for loop to find indices of repeated elements and nullify their values
// This took me about 30 minutes. 
//Question 4
// This one helped me to use 2d arrays and decipher the logic behind finding the common ground for elements in the diagonal which i added 
// in the condition. It took me 20 minutes to solved it.
//Question 5
// This was pretty much a no brainer as i had both indices and actual array elements that were sufficient to create a new array of elements 
// at new indices. However i struggled a bit to find a way to return the new char array as a string which is a new learning for me.
// This made me take 20 minutes for the problem.
//Question 6
// I used a similar logic as q1 here to find index first and then reverse. This helped me learn how to conditionally reverse a string part 
// which is different from the typical reverse string problem we usually encounter. It took me about 10 minutes.