using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationForm
{
    class ReverseString
    {
        private object lblDescription;
        public string description = "A simple challenge to reverse a string input \n without the use of reverse methods.";
        public string Reverse(string input) {
            int lengthHalfed;
            int strLength = input.Trim().Length;
            if (strLength == 0)
            {

                return "Empty input not allowed.";
            }
            else if (strLength % 2 != 0)
            {
                lengthHalfed = (strLength + 1) / 2;
            }
            else
            {
                lengthHalfed = strLength / 2;
            }
            StringBuilder strTemp = new StringBuilder(input.Trim());
                for (int i = 0; i < lengthHalfed; i++)
                {
                    Char charTemp = strTemp[i];
                    strTemp[i] = strTemp[strLength - (i + 1)];
                    strTemp[strLength - (i + 1)] = charTemp;
                }


                string result = strTemp.ToString();
                return result;
            
           
        }
    }
}
