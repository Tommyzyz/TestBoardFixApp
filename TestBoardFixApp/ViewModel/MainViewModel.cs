

namespace TestBoardFixApp.ViewModel;

public partial class MainViewModel:ObservableObject
{
    [RelayCommand]
    private async Task OutputXLS()
    {
        await CreatexlsServices.createExcel();
    }



    [RelayCommand]
    public async Task AddToDatabase()
    {
        using TestDbContext db = new TestDbContext();
        FixFileData File = new FixFileData();
        File.Abnormalphenomena = "ahjwdb";
        File.AbnormalString = "异常";
        File.BoardName = "LPC";
        File.BoardNum = "76567";
        File.FixWay = "自主维修";
        File.ProductName = "PAI37928";
        File.RegisteredPerson = "ADMIN";
        File.StartFixDate = DateTime.Now;
        File.TestMachingNum = "TT-620";
        File.TestMachingType = "STS8200";

        db.FixFileData.Add(File);

        await db.SaveChangesAsync();

    }

    //[RelayCommand]
    //public static bool Trylogin(string username)
    //{
    //   return loginServices.login(username);
    //}

}

