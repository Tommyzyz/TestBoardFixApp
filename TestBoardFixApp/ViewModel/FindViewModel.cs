
namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel:ObservableObject
{

    [ObservableProperty]
    private List<FixFileData> searchedFixFile= new TestDbContext().FixFileData.ToList<FixFileData>();

    //[ObservableProperty]
    //private List<FixFileData> selectedFixFile = new();


    [RelayCommand]
    private void Search(string SearchString)
    {
        if(SearchString!=null) 
        {
            using TestDbContext db = new TestDbContext();
            SearchedFixFile = db.FixFileData.Where(item => item.TestMachingType.Contains(SearchString)||
                                                     item.TestMachingNum.Contains(SearchString)||
                                                     item.RegisteredPerson.Contains(SearchString)||
                                                     item.Abnormalphenomena.Contains(SearchString)||
                                                     item.AbnormalString.Contains(SearchString)||
                                                     item.StartFixDate.ToString().Contains(SearchString)||
                                                     item.BoardName.Contains(SearchString)||
                                                     item.BoardNum.Contains(SearchString)||
                                                     item.ProductName.Contains(SearchString)).ToList();
        }
    }
}
