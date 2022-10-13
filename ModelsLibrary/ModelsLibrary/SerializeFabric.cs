using ModelsLibrary.Questions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary
{
    public static class SerializeFabric<T> where T : Question
    {
        public static T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All});
        }

        public static string Serialize(T question)
        {
            return JsonConvert.SerializeObject(question, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }
    }
}
