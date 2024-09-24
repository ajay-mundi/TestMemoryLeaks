using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFChat : ContentPage
{
	public TestSFChat()
	{
		InitializeComponent();
	}

	 ~TestSFChat()
    {
        Debug.WriteLine("Finalizer: SFChat");
    }
}
