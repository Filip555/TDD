using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example
{
public class Calculator
{
    public int Divided(int a,int b)
    {
            if (b == 0) { throw new ExecutionEngineException(); }
            return a / b;
    }
}
}
