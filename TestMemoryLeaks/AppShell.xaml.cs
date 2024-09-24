namespace TestMemoryLeaks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BasePage), typeof(BasePage));
		Routing.RegisterRoute(nameof(TestSFAccordion), typeof(TestSFAccordion));
		Routing.RegisterRoute(nameof(TestSFActivityIndicator), typeof(TestSFActivityIndicator));
		Routing.RegisterRoute(nameof(TestSFCarousel), typeof(TestSFCarousel));
		Routing.RegisterRoute(nameof(TestSFChat), typeof(TestSFChat));
		Routing.RegisterRoute(nameof(TestSFComboBox), typeof(TestSFComboBox));
		Routing.RegisterRoute(nameof(TestSFDatePicker), typeof(TestSFDatePicker));
		Routing.RegisterRoute(nameof(TestSFDateTimePicker), typeof(TestSFDateTimePicker));
		Routing.RegisterRoute(nameof(TestSFImageEditor), typeof(TestSFImageEditor));
		Routing.RegisterRoute(nameof(TestSFPDFEditor), typeof(TestSFPDFEditor));
		Routing.RegisterRoute(nameof(TestSFScheduler), typeof(TestSFScheduler));
		Routing.RegisterRoute(nameof(TestSFTabView), typeof(TestSFTabView));
		Routing.RegisterRoute(nameof(TestSFTimePicker), typeof(TestSFTimePicker));
		Routing.RegisterRoute(nameof(TestSFTreeView), typeof(TestSFTreeView));
	}
}

