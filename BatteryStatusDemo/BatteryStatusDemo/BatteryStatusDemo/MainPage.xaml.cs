using Plugin.Battery;
using Xamarin.Forms;

namespace BatteryStatusDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    RemainingChargePercent.Text = "RemainingChargePercent: " + CrossBattery.Current.RemainingChargePercent + " %";
		    Status.Text = "Status: " + CrossBattery.Current.Status;
		    PowerSource.Text = "PowerSource: " + CrossBattery.Current.PowerSource;
        }
	}
}
