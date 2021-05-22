using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculater
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string input)
        {
            double convertNumber;
            if (!double.TryParse(input, out convertNumber)) throw new ArgumentException("Accepted a numeric value");
            return convertNumber;
        }

    }
}
