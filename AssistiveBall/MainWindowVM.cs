using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace AssistiveBall
{

	public interface IMainWindowVM
	{
		ICommand CloseCmd { get; }
		bool IsExpanded { get; set; }
	}

	public class MainWindowVM : ObservableObject, IMainWindowVM
	{

		public ICommand CloseCmd { get; }

		[Magic]
		public bool IsExpanded { get; set; }

		public MainWindowVM()
		{
			CloseCmd = new RelayCommand(onCloseCmdExecute);
		}

		private void onCloseCmdExecute()
		{
			IsExpanded = !IsExpanded;
		}
	}
}