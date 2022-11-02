using Microsoft.Win32;
using ModelsLibrary.Questions;
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
using WpfApplication1;
using СonstructorVVK.ViewModel;

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для CreateQuestionView.xaml
    /// </summary>
    public partial class CreateQuestionView : UserControl, ICreateQuestionWindowsCodeBehind
    {
        private CreateQuestionWindowViewModel createQuestionVM;
     
        //   private CreateQuestionViewModel createQuestionViewModel;
        public CreateQuestionView()
        {
            InitializeComponent();
            
            // this.DataContext += CreateQuestionWindow_Loaded;
           // createQuestionViewModel = new CreateQuestionViewModel();
            this.Loaded += CreateQuestionWindow_Loaded;
        }
        private void CreateQuestionWindow_Loaded(object sender, RoutedEventArgs e)
        {
            createQuestionVM = new CreateQuestionWindowViewModel(new DefaultDialogService());
            createQuestionVM.CodeBehind = this;
            this.DataContext = createQuestionVM;
            LoadView(ViewType.ChoiseOneQuestion);
        }

        public void SetString(String str)
        {
            createQuestionVM.DisplayedImagePath = str;
        }
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Main:
                    MainView view = new MainView();
                    this.OutputView.Content = view;
                    break;
                case ViewType.Settings:
                    SettingsView viewF = new SettingsView();
                    this.OutputView.Content = viewF;
                    break;
                case ViewType.ChoiseQuestion:
                    ChoiseQuestionView viewC = new ChoiseQuestionView();
                    this.OutputView.Content = viewC;
                    break;
                case ViewType.ChoiseOneQuestion:
                    ChoiseOneQuestion viewO = new ChoiseOneQuestion();
                    this.OutputView.Content = viewO;
                    break;
                case ViewType.TextQuestion:
                    TextQuestionView viewT = new TextQuestionView();
                    this.OutputView.Content = viewT;
                    break;
                case ViewType.SequenceQuestion:
                    SequenceQuestionView viewQ = new SequenceQuestionView();
                    this.OutputView.Content = viewQ;
                    break;

            }

        }
        private string displayedImagePath = "/recources/images/logo.png";
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                displayedImagePath = openFileDialog.FileName;
                image1.Source = new BitmapImage(new Uri(displayedImagePath));

            }
          
        }
    }
}
