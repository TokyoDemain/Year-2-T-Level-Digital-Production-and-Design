using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public float number1;
        public float number2;
        public float result;

        public float multiply(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
            result = number2 * num1;
            return result;
        }
        public float divide(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
            result = number2 / num1;
            return result;
        }
        public float subtract(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
            result = number2 - num1;
            return result;
        } 
        public float addition(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
            result = number2 + num1;
            return result;
        }
    }
}
