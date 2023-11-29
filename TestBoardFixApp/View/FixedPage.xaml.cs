
namespace TestBoardFixApp.View;

public partial class FixedPage : ContentPage
{
	public FixedPage(FixedViewModel viewModel )
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private async void Button_ClickedAsync(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", "±£´æ³É¹¦", "OK");
    }
}