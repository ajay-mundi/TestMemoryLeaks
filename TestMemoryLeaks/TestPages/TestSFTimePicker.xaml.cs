using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFTimePicker : ContentPage
{
	public TestSFTimePicker()
	{
		InitializeComponent();
	}

	 ~TestSFTimePicker()
    {
        Debug.WriteLine("Finalizer: SFTimePicker");
    }
}
