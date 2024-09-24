using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFScheduler : ContentPage
{
	public TestSFScheduler()
	{
		InitializeComponent();
	}

	 ~TestSFScheduler()
    {
        Debug.WriteLine("Finalizer: SFScheduler");
    }
}
