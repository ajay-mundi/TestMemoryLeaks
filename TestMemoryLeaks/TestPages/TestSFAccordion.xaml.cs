using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFAccordion : ContentPage
{
	public TestSFAccordion()
	{
		InitializeComponent();
	}

	 ~TestSFAccordion()
    {
        Debug.WriteLine("Finalizer: SFAccordion");
    }
}
