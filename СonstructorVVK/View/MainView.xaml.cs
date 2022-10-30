using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
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

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>

    public partial class MainView : UserControl
    {
       
        private MainViewModel mainViewModel;
        public MainView()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
           
        }

    }
   
}
   
