using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class SharedScope
    {
        public List<Var> Vars { get; set; }

        public SharedScope()
        {
            Vars = new List<Var>();
        }

        public void AddVariable(string name, double value)
        {
            Vars.Add(new Var(name, value));
        }
    }
}
