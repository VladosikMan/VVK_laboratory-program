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
    /// Логика взаимодействия для CreateQuestionView.xaml
    /// </summary>
    public partial class CreateQuestionView : UserControl
    {
        private CreateQuestionViewModel createQuestionViewModel;
        public CreateQuestionView()
        {
            InitializeComponent();
            createQuestionViewModel = new CreateQuestionViewModel();
            this.DataContext = createQuestionViewModel;
        }
    }
}
