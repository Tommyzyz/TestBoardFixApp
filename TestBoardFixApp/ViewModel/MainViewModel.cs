

namespace TestBoardFixApp.ViewModel;

public partial class MainViewModel:ObservableObject
{
    [RelayCommand]
    private void OutputXLS()
    {
        CreatexlsServices.createExcel();
    }

    //[RelayCommand]
    //public static bool Trylogin(string username)
    //{
    //   return loginServices.login(username);
    //}

}

