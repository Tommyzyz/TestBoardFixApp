namespace TestBoardFixApp.ViewModel;

public partial class MainViewModel(TestDbContext db):ObservableObject
{
    [RelayCommand]
    private void OutputXLS()
    {
        CreatexlsServices.WriteExcelFile(db);
    }



    [RelayCommand]
    public async Task AddToDatabase()
    {
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
        
        var FixedData = new FixedFileData();
        FixedData.TestingMethod = "检测继电器接触";
        FixedData.FixdMethod = "更换继电器";
        FixedData.EndFixDate = DateTime.Now;
        FixedData.RegisteredPerson = "张三";
        File.FixedFileData = FixedData;
        db.FixFileData.Add(File);

        await db.SaveChangesAsync();

    }

    //[RelayCommand]
    //private void Search()
    //{
    //        var result = db.FixFileData.Include(a=>a.FixedFileData).Single(a=>a.ID==2);
    //        Console.WriteLine(result.FixedFileData.FixdMethod);
    //}

    //[RelayCommand]
    //public static bool Trylogin(string username)
    //{
    //   return loginServices.login(username);
    //}

}

