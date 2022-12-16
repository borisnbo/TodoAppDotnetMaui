using MauiApp8.ViewModels;

namespace MauiApp8;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var vm = new MainViewModels();
		MainPage = new Pages.Task(vm);
	}
}
