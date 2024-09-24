using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFDatePicker : ContentPage
{
	public TestSFDatePicker()
	{
		InitializeComponent();
	}

	 ~TestSFDatePicker()
    {
        Debug.WriteLine("Finalizer: SFDatePicker");
    }
}
