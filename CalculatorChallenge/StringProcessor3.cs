using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class StringProcessor3
    {
        public StringProcessor3() { }
        public int getSum(string userInput)
        {
            var result = 0;
            var parsedInput = userInput.Split(new[] { "\\n", "," }, StringSplitOptions.None);

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
