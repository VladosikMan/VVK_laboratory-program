using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class TaskQuestion : TextQuestion
    {
        public string Expression { get; set; }

        //[JsonProperty]
        //private SharedScope SharedScope;

        public TaskQuestion(string text, double rate, string expression) 
            : base(text, string.Empty, rate)
        {
            Expression = expression;
        }

        public override string SerializeClientVersion()
        {
            var clientVersion = new TaskQuestion(Text, Rate, Expression);

            return SerializeFabric<TaskQuestion>.Serialize(clientVersion);
        }

        public double GetRate(TaskQuestion question)
        {
            // TODO: Expression calc
            // Тут берешь _sharedScope, проходишься там по var's и подставляешь в expression

            return Rate;
        }

     /*   public void SetSharedScope(SharedScope sharedScope)
        {
            SharedScope = sharedScope;
        }*/

    }
}
