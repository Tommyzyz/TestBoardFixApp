

using System.IO.Compression;

namespace TestBoardFixApp.View;

public partial class FixPage : ContentPage
{
	public FixPage(FixViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}


    private async void Button_ClickedAsync(object sender, EventArgs e)
    {
        
        await DisplayAlert("Alert", "±£´æ³É¹¦", "OK");
    }

}