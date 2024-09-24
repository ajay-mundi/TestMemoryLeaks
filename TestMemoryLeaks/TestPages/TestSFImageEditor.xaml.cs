using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFImageEditor : ContentPage
{
	public TestSFImageEditor()
	{
		InitializeComponent();
	}

	 ~TestSFImageEditor()
    {
        Debug.WriteLine("Finalizer: SFImageEditor");
    }
}
