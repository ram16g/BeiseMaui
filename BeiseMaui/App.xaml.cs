
namespace BeiseMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Shell.Current.CurrentItem = PhoneTabs;
	}

}
