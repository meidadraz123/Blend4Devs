using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DesignWithBlend
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void theButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
      LayoutRoot.Background = new SolidColorBrush(Colors.Gray);
		}

		private void theButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
      LayoutRoot.Background = new SolidColorBrush(Colors.White);
		}
	}
}