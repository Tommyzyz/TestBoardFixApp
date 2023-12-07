
namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel:ObservableObject
{

    [ObservableProperty]
    private List<FixFileData> searchedFixFile= new TestDbContext().FixFileData.ToList<FixFileData>();

    [ObservableProperty]
    private List<FixFileData> selectedFixFile = new();

    [ObservableProperty]
    private string searchString;

    [RelayCommand]
    private void Search()
    {
        using TestDbContext db = new TestDbContext();

        SearchedFixFile = db.FixFileData.Where(item => item.TestMachingType.Contains(SearchString)).ToList();
        //SavedFixFiles.fixFiles.AddRange(db.FixFileData);
        //foreach (FixFileData data in db.FixFileData) 
        //{
        //    // SelectedFixFile.Add(data);

        //    SavedFixFiles.fixFiles.Add(data);
        //}
        //foreach(FixFileData data in SavedFixFiles.fixFiles) 
        //{
        //    if (data.ProductName == SearchString || data.TestMachingNum == SearchString || data.TestMachingType == SearchString || data.BoardName == SearchString || data.BoardNum == SearchString)
        //    SelectedFixFile.Add(data);
        //}
    }
}
