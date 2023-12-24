using CommunityToolkit.Maui.Storage;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TestBoardFixApp.View;

namespace TestBoardFixApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<FixPage>();
            builder.Services.AddSingleton<FixViewModel>();
            builder.Services.AddSingleton<FixedPage>();
            builder.Services.AddSingleton<FixedViewModel>();
            builder.Services.AddSingleton<FindPage>();
            builder.Services.AddSingleton<FindViewModel>();
            builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);
            builder.Services.AddDbContext<TestDbContext>(opt => {
                string connStr = ConfigurationManager.ConnectionStrings["TestDbConnectString"].ToString();
                opt.UseNpgsql(connStr);
            });

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
