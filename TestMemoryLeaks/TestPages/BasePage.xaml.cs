using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class BasePage : ContentPage
{
	public BasePage()
	{
		InitializeComponent();
	}

	~BasePage()
	{
		Debug.WriteLine("Finalizer: BasePage");
	}

}


