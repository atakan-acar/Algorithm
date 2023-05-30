using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Console
{
    public static class AlgorithmSolution
    {
        public static Dictionary<int, int> FindRepeatNumber(int[] numbers)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];

                var tryGet = result.TryGetValue(temp, out int value);

                if (tryGet)
                {
                    int resultx = value + 1;
                    result[temp] = resultx;
                }
                else
                {
                    result.Add(temp, 1);
                }

            }
            return result;
        }

        public static (int, int) FindNumber(int[] numbers)
        {
            int minValue = numbers[0];
            int maxValue = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = numbers[i];

                if (temp > maxValue)
                    maxValue = temp;

                if (temp < minValue)
                    minValue = temp;
            }
            return (maxValue, minValue);
        }
        public static int[] FindSingleNumber(int[] numbers)
        {
            List<int> singleNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                if (temp % 2 != 0)
                {
                    singleNumbers.Add(temp);
                }
            }
            return singleNumbers.ToArray();
        }

        public static string FindRepeatWord(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            if (!words.Any()) return String.Empty;

            Dictionary<string, int> wordsWorld = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordt = word.ToLower();

                if (wordsWorld.TryGetValue(wordt, out int count))
                    wordsWorld[wordt] = count + 1;
                else
                    wordsWorld[wordt] = 1;

            }

            string key = "";
            int wordCount = 0;

            foreach (var item in wordsWorld)
            {
                if (item.Value > wordCount)
                {
                    wordCount = item.Value;
                    key = item.Key;
                }
            }
            return key;
        }

        public static string ReverseText(string text)
        {
            string[] words = text.Split(' ');
            StringBuilder builder = new StringBuilder();
            for (int i = words.Length - 1; i != -1; i--)
            {
                if (i != words.Length - 1)
                    builder.Append(" ");

                builder.Append(words[i]);
            }
            return builder.ToString();
        }

        public static int MaxDifference(int[] numbers)
        {

            int minValue = numbers[0];
            int maxValue = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = numbers[i];
                if (maxValue < temp)
                    maxValue = temp;

                if (minValue > temp)
                    minValue = temp;
            }

            return maxValue - minValue;
        }


        public static (string, int) FindLongestWorld(string text)
        {
            var words = text.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            int maxLength = 0;
            string findedWord = "";

            foreach (var word in words)
            {
                if (word.Length > maxLength)
                {

                    findedWord = word;
                    maxLength = word.Length;
                }
            }
            return (findedWord, maxLength);
        }

        //A man, a plan, a canal: Panama
        public static bool IsPalindrome(string s)
        {
            string[] words = s.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            s = s.ToLower();
            s = s.Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace(";", "")
                .Replace(":", "")
                .Replace("? ", "")
                .Replace("!", "");


            StringBuilder builder = new StringBuilder();
            for (int i = words.Length - 1; i != -1; i--)
            {
                var word = words[i].ToLower();

                foreach (char c in word.Reverse())
                {
                    builder.Append(c);
                } 
            } 
            return s.Equals(builder.ToString());
        }
        public static int SearchNum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums[i];

                if (target == temp)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            var array = new int[] { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                var number = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;

                    var temp = nums[j];

                    if (number + temp == target)
                    {
                        array[0] = i;
                        array[1] = j;
                    }


                }
            }

            return array;
        }


        public static bool BracketIsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (IsOpeningBracket(c))
                {
                    stack.Push(c);
                }
                else if (IsClosingBracket(c))
                {
                    if (stack.Count == 0 || !AreBracketsMatching(stack.Peek(), c))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        private static bool IsOpeningBracket(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        private static bool IsClosingBracket(char c)
        {
            return c == ')' || c == '}' || c == ']';
        }

        private static bool AreBracketsMatching(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}
