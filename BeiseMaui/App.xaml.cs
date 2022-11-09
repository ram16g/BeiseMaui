
namespace BeiseMaui;

using BeiseMaui.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Shell.Current.CurrentItem = PhoneTabs;

        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
    }

}
