using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для SettingsLabView.xaml
    /// </summary>
    public partial class SettingsLabView : UserControl
    {
        private SettingsLabViewModel settingsLabViewModel = new SettingsLabViewModel(); 
        public SettingsLabView()
        {
            InitializeComponent();
            this.DataContext = settingsLabViewModel;
       

        }
        public void SetLab(Lab lab)
        {
            settingsLabViewModel.SelectedLab = lab;
        }
     
    }
}
