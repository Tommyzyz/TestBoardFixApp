

using System.IO.Compression;

namespace TestBoardFixApp.View;

public partial class FixPage : ContentPage
{
	public FixPage(FixViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}