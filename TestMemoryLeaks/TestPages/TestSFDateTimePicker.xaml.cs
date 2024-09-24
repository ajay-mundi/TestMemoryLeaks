using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFDateTimePicker : ContentPage
{
	public TestSFDateTimePicker()
	{
		InitializeComponent();
	}

	 ~TestSFDateTimePicker()
    {
        Debug.WriteLine("Finalizer: SFDateTimePicker");
    }
}
