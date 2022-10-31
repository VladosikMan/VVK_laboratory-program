using System;
using System.Collections.Generic;
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
using WpfMath.Controls;

namespace WpfApp2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void TextFormula_TextChanged(object sender, TextChangedEventArgs e)
		{
			
		}

		private void TextFormula_SelectionChanged(object sender, RoutedEventArgs e)
		{
			Formula.SelectionStart = TextFormula.SelectionStart;
			Formula.SelectionLength = TextFormula.SelectionLength;
		}

		private void SecondTextFormula_SelectionChanged(object sender, RoutedEventArgs e)
		{
			try
			{
				//if (converter != null && translator != null && translator.CheckSyntax(SecondTextFormula.Text))
				//{
				//	TextFormula.Text = converter.Convert(SecondTextFormula.Text);
				//}
				//if (length != SecondTextFormula.Text.Length)
				//{
				//	lastChar = SecondTextFormula.Text[SecondTextFormula.SelectionStart - 1];
				//}
				//else 
				//{
				//	lastChar = ' ';
				//}
				TextFormula.Text = TestParse.PrintDel(TestParse.PrintScobe(SecondTextFormula.Text));

				Formula.SelectionStart = TextFormula.SelectionStart;
				Formula.SelectionLength = TextFormula.SelectionLength;
			} catch 
			{
				
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var focus = SecondTextFormula.SelectionStart+2;
			SecondTextFormula.Text = SecondTextFormula.Text.Insert(SecondTextFormula.SelectionStart, "∑()");
			SecondTextFormula.Focus();
			SecondTextFormula.SelectionStart = focus;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var focus = SecondTextFormula.SelectionStart + 2;
			SecondTextFormula.Text = SecondTextFormula.Text.Insert(SecondTextFormula.SelectionStart, "√()");
			SecondTextFormula.Focus();
			SecondTextFormula.SelectionStart = focus;
		}
	}
}
