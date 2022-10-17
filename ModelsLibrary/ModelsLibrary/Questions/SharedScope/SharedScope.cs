using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class SharedScope
    {
      //  public List<Var> Vars { get; set; }
        private Dictionary<string, Var> Vars {get;set;}
        public SharedScope()
        {
            //Vars = new List<Var>();
            Vars = new Dictionary<string, Var>();
        }

        public void AddVariable(string name, double value)
        {
            //Vars.Add(new Var(name, value));
            //Vars.Add(new Var(name, value));
            Vars.Add(name, new Var(name, value));
        }
        public void DeleteVariable(string key)
        {
            Vars.Remove(key);
        }
        public void UpdateVariable(string key, Var newVar)
        {
            Vars[key] = newVar;
        }
        public Var GetVariable(string key)
        {
            return Vars[key];
        }
    }
}
