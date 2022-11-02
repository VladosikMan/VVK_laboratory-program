using ModelsLibrary.Questions;
using System.Windows.Controls;
using СonstructorVVK.ViewModel;

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsQuestionView.xaml
    /// </summary>
    public partial class SettingsQuestionView : UserControl
    {
        private SettingsQuestionViewModel settingsQuestionViewModel = new SettingsQuestionViewModel();
        public SettingsQuestionView()
        {
            InitializeComponent();
            this.DataContext = settingsQuestionViewModel;
        }
        public void SetQuestion(Question question)
        {
            settingsQuestionViewModel.SelectedQuestion = question;
        }
    }
}
