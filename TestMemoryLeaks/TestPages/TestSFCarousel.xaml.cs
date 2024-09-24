using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class TestSFCarousel : ContentPage
{
	public TestSFCarousel()
	{
		InitializeComponent();
	}

	~TestSFCarousel()
	{
		Debug.WriteLine("Finalizer: SFCarousel");
	}
}
