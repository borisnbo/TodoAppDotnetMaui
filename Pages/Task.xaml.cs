using MauiApp8.ViewModels;

namespace MauiApp8.Pages;

public partial class Task : ContentPage
{
	public Task(MainViewModels vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}