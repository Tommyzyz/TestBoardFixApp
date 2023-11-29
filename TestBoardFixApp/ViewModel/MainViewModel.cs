

namespace TestBoardFixApp.ViewModel;

public partial class MainViewModel:ObservableObject
{
    [RelayCommand]
    private void OutputXLS()
    {
        CreatexlsServices.createExcel();
    }

    //[RelayCommand]
    //public bool TryLogin(string username, string password)
    //{
    //   return loginServices.login(username, password);
    //}

}

