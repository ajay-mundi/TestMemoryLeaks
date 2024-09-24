using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFActivityIndicator : ContentPage
{
	public TestSFActivityIndicator()
	{
		InitializeComponent();
	}

	protected override void OnAppearing(){
		busyIndicator.IsRunning = true;
	}

	 ~TestSFActivityIndicator()
    {
        Debug.WriteLine("Finalizer: SFActivityIndicator");
    }
}
