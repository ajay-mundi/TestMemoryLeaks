using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace TestMemoryLeaks;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.ConfigureSyncfusionCore();

#if DEBUG
		builder.Logging.AddDebug();
		// Ensure UseLeakDetection is called after logging has been configured!
		builder.UseLeakDetection(collectionTarget =>
		{
			// This callback will run any time a leak is detected.
			// Application.Current?.MainPage?.DisplayAlert("💦Leak Detected💦",
			// 	$"❗🧟❗{collectionTarget.Name} is a zombie!", "OK");
		});
#endif
		builder.Services.AddTransient<BasePage>();
		builder.Services.AddTransient<TestSFAccordion>();
		builder.Services.AddTransient<TestSFActivityIndicator>();
		builder.Services.AddTransient<TestSFCarousel>();
		builder.Services.AddTransient<TestSFChat>();
		builder.Services.AddTransient<TestSFComboBox>();
		builder.Services.AddTransient<TestSFDatePicker>();
		builder.Services.AddTransient<TestSFDateTimePicker>();
		builder.Services.AddTransient<TestSFImageEditor>();
		builder.Services.AddTransient<TestSFPDFEditor>();
		builder.Services.AddTransient<TestSFScheduler>();
		builder.Services.AddTransient<TestSFTabView>();
		builder.Services.AddTransient<TestSFTimePicker>();
		builder.Services.AddTransient<TestSFTreeView>();
		return builder.Build();
	}
}

