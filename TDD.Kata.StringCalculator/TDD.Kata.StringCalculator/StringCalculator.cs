using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Kata.StringCalculator
{
    public class StringCalculator
    {
        public int add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            int sum = 0;
            foreach (string number in numbers.Split(',','\n'))
            {
                sum += Convert.ToInt32(number);
            }

            return sum;
        }
    }
}
