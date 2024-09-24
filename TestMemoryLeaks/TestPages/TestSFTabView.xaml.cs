using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFTabView : ContentPage
{
	public TestSFTabView()
	{
		InitializeComponent();
	}

	 ~TestSFTabView()
    {
        Debug.WriteLine("Finalizer: SFTabView");
    }
}
