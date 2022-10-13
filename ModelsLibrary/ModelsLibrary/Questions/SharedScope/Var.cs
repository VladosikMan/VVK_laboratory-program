using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class Var
    {
        public string Name { get; set; }

        public double Value { get; set; }

        public Var(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
