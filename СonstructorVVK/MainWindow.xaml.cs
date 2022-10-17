
using ModelsLibrary;
using ModelsLibrary.Questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using СonstructorVVK.ViewModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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
    }

   

}
