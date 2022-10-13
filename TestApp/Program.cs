using ModelsLibrary;
using ModelsLibrary.Questions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lab = new Lab("Первая лаба", 80);

            var questions = new List<Question>()
            {
                new TextQuestion("Сколько стоит слон?", "10 рублей", 5),
                new ChoiceQuestion("Кто живет в Африке?", new List<string>()
                {
                    "Слон",
                    "Мартышка",
                    "Белый медведь"
                }, new List<string>()
                {
                    "Слон",
                    "Мартышка"
                }, 15)
            };
            lab.AddSubject("Тест", questions);

            var scope = new SharedScope();
            scope.AddVariable("A", 5);
            scope.AddVariable("B", 3);
            scope.AddVariable("C", 0);
            scope.AddVariable("D", 0);

            var task = new TaskQuestion("Задача, посчитайте c = a * b, при a = 5, b = 3", 20, "c = a * b");
            task.SetSharedScope(scope);

            var task2 = new TaskQuestion("Задача, посчитайте d = c + 5", 20, "d = c + 5");
            task2.SetSharedScope(scope);

            questions = new List<Question>()
            {
                task,
                task2
            };
            lab.AddSubject("Задачи от Жака Фреско", questions);
            lab.AddSharedScope(scope);

            string json = lab.Serialize();

            var deserializedLab = new Lab();
            deserializedLab.Deserialize(json);

            Console.ReadKey();
        }
    }
}
