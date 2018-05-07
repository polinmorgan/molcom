using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testM
{
    public  class MathString : IMathString
    {
        public  string Inc(string inputValue)
        {
            string str = string.Empty;
            double result;

            if (!string.IsNullOrEmpty(inputValue) && !string.IsNullOrWhiteSpace(inputValue))
            {
                try
                {
                    result= Double.Parse(inputValue);
                    result++;
                    str = result.ToString();
                }
                catch 
                {
                    str = "Input value is not number";
                }
            }
            else
            {
                str = "Input value is empty"; 
            }

            return str;  
        }

       
    }
}
