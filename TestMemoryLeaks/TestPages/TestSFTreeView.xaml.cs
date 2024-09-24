using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFTreeView : ContentPage
{
	public TestSFTreeView()
	{
		InitializeComponent();
	}

	 ~TestSFTreeView()
    {
        Debug.WriteLine("Finalizer: SFTreeView");
    }
}
