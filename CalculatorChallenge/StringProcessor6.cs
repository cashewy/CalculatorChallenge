using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorChallenge
{
    public class StringProcessor6
    {
        public StringProcessor6() { }
        public int getSum(string userInput)
        {
            var result = 0;
            var delimiters = new List<string> { "\\n", "," };
            var negativeList = new List<int>();

            try
            {
                var delimterList = checkForCustomDelimiter(userInput, delimiters);
                var parsedInput = userInput.Split(delimterList, StringSplitOptions.None);

                foreach (string num in parsedInput)
                {
                    int tempNum = 0;

                    if (int.TryParse(num, out tempNum))
                    {
                        checkForNegativeValue(tempNum, negativeList);
                        if (tempNum > 1000)
                        {
                            tempNum = 0;
                        }
                        result += tempNum;
                    }
                    else
                    {
                        result += 0;
                    }
                }

                if (negativeList.Count > 0)
                {
                    var negativeNumbersString = string.Join(",", negativeList.Select(n => n.ToString()).ToArray());
                    throw new ArgumentException(String.Format("Negative numbers are not allowed: {0}", negativeNumbersString));
                }

            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }

            return result;
        }

        private string[] checkForCustomDelimiter(string userInput, List<string> delimiters)
        {
            var customRegex = @"(\/\/(.)\\n)";
            var singleCharRegex = Regex.Match(userInput, customRegex);

            if (singleCharRegex.Success)
            {
                delimiters.Add(singleCharRegex.Groups[2].ToString());
            }

            return delimiters.ToArray();
        }

        private void checkForNegativeValue(int num, List<int> negativeList)
        {
            if (num < 0)
            {
                negativeList.Add(num);
            }

        }

    }
}
