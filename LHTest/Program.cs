﻿using LHTest.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOperator> operators = OperatorLoader.LoadOperators();
        }
    }
}
