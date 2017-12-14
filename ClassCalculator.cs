using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class ClassCalculator
    {
     public class Calculator
        {        
            
            public double Square(double num) => num * num;

            public double Add(double num1, double num2) => num1 + num2;
            public double Multiply(double  num1, double num2) => num1 * num2;
            public double Divide(double num1, double num2) => num2 / num1;
            public double Subtract(double num1, double num2)
            {
                if (num1 > num2) 
                {
                    return num1 - num2;
                }
                return num2 - num1;
            }

        }



       



    }
}
