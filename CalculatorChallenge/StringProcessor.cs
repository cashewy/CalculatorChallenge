using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class StringProcessor
    {
        public StringProcessor() { }
        public int getSum(string userInput)
        {
            char[] delimiters = { ',' };
            var result = 0;
            var parsedInput = userInput.Split(delimiters);

            try
            {
                if (parsedInput.Length > 2)
                {
                    throw new ArgumentException(String.Format("User input invalid {0}: input exceed limit of 2 ", userInput));
                }
                else
                {
                    foreach (string num in parsedInput)
                    {
                        int tempNum = 0;

                        if (int.TryParse(num, out tempNum))
                        {
                            result += tempNum;
                        }
                        else
                        {
                            result += 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return result;
        }
    }
}
