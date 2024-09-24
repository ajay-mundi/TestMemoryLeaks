namespace TestMemoryLeaks;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");
		MainPage = new AppShell();
	}
}

