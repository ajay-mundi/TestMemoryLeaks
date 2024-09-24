using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFComboBox : ContentPage
{
	public TestSFComboBox()
	{
		InitializeComponent();
	}

	~TestSFComboBox()
	{
		Debug.WriteLine("Finalizer: SFComboBox");
	}
}


