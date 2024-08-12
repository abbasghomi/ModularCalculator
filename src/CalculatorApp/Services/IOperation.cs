﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Services
{
    public interface IOperation
    {
        string Symbol { get; }
        double Operate(double a, double b);
    }
}
