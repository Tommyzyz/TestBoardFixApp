
namespace TestBoardFixApp.View;

public partial class FixedPage : ContentPage
{
	public FixedPage(FixedViewModel viewModel )
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}