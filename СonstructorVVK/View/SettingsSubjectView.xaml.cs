using ModelsLibrary;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для SettingsSubjectView.xaml
    /// </summary>
    public partial class SettingsSubjectView : UserControl
    {
        private SettingsSubjectViewModel settingsSubjectViewModel = new SettingsSubjectViewModel();
        public SettingsSubjectView()
        {
            InitializeComponent();
            this.DataContext = settingsSubjectViewModel;
        }
        public void SetSubject(Subject subject)
        {
            settingsSubjectViewModel.SelectedSubject = subject;
        }
    }
}
