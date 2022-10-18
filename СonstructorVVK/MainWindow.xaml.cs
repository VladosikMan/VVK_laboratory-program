
using ModelsLibrary;
using ModelsLibrary.Questions;
using System.Collections.Generic;
using System.Windows;
using СonstructorVVK.ViewModel;
using System.Collections.Specialized;
using ModelsLibrary.Questions.Scope;
using ModelsLibrary.Questions.Variants;

namespace СonstructorVVK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            mainViewModel.labs.CollectionChanged += Lab_CollectionChanged;

        }
        private void Lab_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    if (e.NewItems?[0] is Lab newLab)
                        label.Content = newLab.Name;   
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление

                    break;
                case NotifyCollectionChangedAction.Replace: // если замена

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //создавать новую лабу тип и обновлять данные
            mainViewModel.createLab();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var scope = new SharedScope();
            scope.AddVariable("A",5);
            scope.GetVariable("A").AddVariant(new VariantInterval(VariantsType.RandomInterval, new List<double> {14,456 }));
            scope.GetVariable("A").AddVariant(new VariantList(VariantsType.RandomInterval, new List<double> {2,4,6,8 }));
            scope.GetVariable("A").AddVariant(new VariantConstant(VariantsType.RandomInterval, 564));

            var variable = scope.GetVariable("A").GenerateVariant(0);
            var variable1 = scope.GetVariable("A").GenerateVariant(1);
            var variable2 = scope.GetVariable("A").GenerateVariant(2);
            var variable3 = scope.GetVariable("A").GenerateVariant(3);
            var que = new ChoiceQuestion("Кто живет в Африке?", new List<string>()
                {
                    "Слон",
                    "Мартышка",
                    "Белый медведь"
                }, new List<string>()
                {
                    "Слон",
                    "Мартышка"
                }, 15);
          

        }
    }
}

