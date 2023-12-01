

namespace TestBoardFixApp.ViewModel;

public partial class MainViewModel:ObservableObject
{
    [RelayCommand]
    private void OutputXLS()
    {
        CreatexlsServices.createExcel();
    }


    [RelayCommand]
    private void AddFiles()
    {
        FixFileData File = new FixFileData();
        File.Abnormalphenomena = "ahjwdb";
        File.AbnormalString="异常";
        File.BoardName = "LPC";
        File.BoardNum = "76567";
        File.FixWay = "自主维修";
        File.ProductName = "PAI37928";
        File.RegisteredPerson = "ADMIN";
        File.StartFixDate= DateTime.Now;
        File.TestMachingNum = "TT-620";
        File.TestMachingType = "STS8200";
        for(int i = 0;i < 10;i++)
        {
            SavedFixFiles.fixFiles.Add(File);
        }

    }

    //[RelayCommand]
    //public static bool Trylogin(string username)
    //{
    //   return loginServices.login(username);
    //}

}

