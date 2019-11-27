using System;
using System.Windows;
using System.Windows.Input;

namespace AssistiveBall
{
	public partial class MainWindow : Window
	{
		private IMainWindowVM viewModel;
		public MainWindow()
		{
			InitializeComponent();
			DataContext = viewModel = new MainWindowVM();
		}

		private void mainButton_MouseDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				if (e.LeftButton == MouseButtonState.Pressed)
				{
					DragMove();
					return;
				}
				viewModel.CloseCmd.Execute(null);
			}
			catch (Exception) { }
		}
	}
}
