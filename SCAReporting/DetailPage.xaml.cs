using SCAReporting.ViewModel;

namespace SCAReporting;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel dvm)
	{
		InitializeComponent();
		BindingContext = dvm;

    }
}