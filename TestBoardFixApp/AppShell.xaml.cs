namespace TestBoardFixApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Routes.FixedPage, typeof(FixedPage));
        }
    }
}
