using System.Diagnostics;

namespace TestMemoryLeaks;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		GC.WaitForPendingFinalizers();
		GC.Collect();
		Debug.WriteLine("GCCollect");
	}

	private async void TestBasePage(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(BasePage));
	}

	private async void TestTestSFAccordion(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFAccordion));
	}

	private async void TestTestSFActivityIndicator(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFActivityIndicator));
	}

	private async void TestTestSFCarousel(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFCarousel));
	}

	private async void TestTestSFChat(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFChat));
	}

	private async void TestTestSFComboBox(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFComboBox));
	}

	private async void TestTestSFDatePicker(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFDatePicker));
	}

	private async void TestTestSFDateTimePicker(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFDateTimePicker));
	}

	private async void TestTestSFImageEditor(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFImageEditor));
	}

	private async void TestTestSFPDFEditor(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFPDFEditor));
	}

	private async void TestTestSFScheduler(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFScheduler));
	}

	private async void TestTestSFTabView(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFTabView));
	}

	private async void TestTestSFTimePicker(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFTimePicker));
	}

	private async void TestTestSFTreeView(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(TestSFTreeView));
	}
}


