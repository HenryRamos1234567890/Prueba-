﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new ArgumentException("No se permite la división por cero");
            }
            return num1 / num2;
        }
    }
}
