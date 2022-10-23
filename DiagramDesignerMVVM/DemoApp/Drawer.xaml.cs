using System;
using System.Collections.Generic;
using System.Linq;
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
using DiagramDesigner.Helpers;
using DiagramDesigner;

namespace DemoApp
{
	/// <summary>
	/// Interaction logic for Drawer.xaml
	/// </summary>
	public partial class Drawer : UserControl
	{
		private Window1ViewModel window1ViewModel;

		public Drawer()
		{
            InitializeComponent();

			window1ViewModel = new Window1ViewModel();
			this.DataContext = window1ViewModel;
			this.Loaded += new RoutedEventHandler(Window1_Loaded);
		}

        /// <summary>
        /// This shows you how you can create diagram items in code, which means you can 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            SettingsDesignerItemViewModel item1 = new SettingsDesignerItemViewModel();
            item1.Parent = window1ViewModel.DiagramViewModel;
            item1.Left = 100;
            item1.Top = 100;
            window1ViewModel.DiagramViewModel.Items.Add(item1);

            PersistDesignerItemViewModel item2 = new PersistDesignerItemViewModel();
            item2.Parent = window1ViewModel.DiagramViewModel;
            item2.Left = 300;
            item2.Top = 300;
            window1ViewModel.DiagramViewModel.Items.Add(item2);

            ConnectorViewModel con1 = new ConnectorViewModel(item1.RightConnector, item2.TopConnector);
            con1.Parent = window1ViewModel.DiagramViewModel;
            window1ViewModel.DiagramViewModel.Items.Add(con1);
        }
    }
}
