using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFPDFEditor : ContentPage
{
	public TestSFPDFEditor()
	{
		InitializeComponent();
	}

	 ~TestSFPDFEditor()
    {
        Debug.WriteLine("Finalizer: SFPDFEditor");
    }
}
