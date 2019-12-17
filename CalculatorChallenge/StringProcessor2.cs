using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class StringProcessor2
    {
        public StringProcessor2() { }

        public int getSum(string userInput)
        {
            char[] delimiters = { ',' };
            var result = 0;
            var parsedInput = userInput.Split(delimiters);

            try
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
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return result;
        }
    }
}
