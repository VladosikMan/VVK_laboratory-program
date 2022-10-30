﻿using ModelsLibrary.Questions;
using ModelsLibrary.Questions.Scope;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ModelsLibrary
{
    [Serializable]
    public class Lab
    {
        public Lab(string json)
        {
            Deserialize(json);
        }


        public string Name { get; set; }
        public int Id { get; set; }

        [JsonProperty]
        private int SuccessPercent { get; set; }

        [JsonProperty]
        public ObservableCollection<Subject> Subjects { get; set; }

        [JsonProperty]
        private List<SharedScope> SharedScopes { get; set; }


        public string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }

        public void Deserialize(string json)
        {
            var lab = JsonConvert.DeserializeObject<Lab>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });

            Name = lab.Name;
            Subjects = lab.Subjects;
            SharedScopes = lab.SharedScopes;
        }

        public Lab()
        {
            Subjects = new ObservableCollection<Subject>();
            SharedScopes = new List<SharedScope>();
        }

        public Lab(string name, int successPercent) : this()
        {
            Name = name;
            SuccessPercent = successPercent;
        }
        public Lab(string name, int successPercent, int id) : this()
        {
            Name = name;
            SuccessPercent = successPercent;
            Id = id;
        }


        public ObservableCollection<Question> GetQuestionsBySubject(string subjectTitle)
        {
            var subject = Subjects.FirstOrDefault(x => x.Title == subjectTitle);

            if (subject == null)
            {
                return new ObservableCollection<Question>();
            }

            return subject.Questions;
        }

        public void AddSubject(string title, ObservableCollection<Question> questions = null)
        {
            if (questions == null)
            {
                questions = new ObservableCollection<Question>();
            }

            Subjects.Add(new Subject(title)
            {
                Questions = questions
            });
        }

        public void AddSharedScope(SharedScope scope)
        {
            SharedScopes.Add(scope);
        }
    }
}
