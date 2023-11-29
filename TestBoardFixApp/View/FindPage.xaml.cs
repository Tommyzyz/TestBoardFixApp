namespace TestBoardFixApp.View;

public partial class FindPage : ContentPage
{
	public FindPage(FindViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}