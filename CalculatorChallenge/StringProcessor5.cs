using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class StringProcessor5
    {
        public StringProcessor5() { }
        public int getSum(string userInput)
        {
            var result = 0;
            var parsedInput = userInput.Split(new[] { "\\n", "," }, StringSplitOptions.None);
            var negativeList = new List<int>();
            try
            {
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

        private void checkForNegativeValue(int num, List<int> negativeList)
        {
            if (num < 0)
            {
                negativeList.Add(num);
            }

        }
    }
}
