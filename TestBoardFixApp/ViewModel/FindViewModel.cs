
using TestBoardFixApp.Data;

namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel:ObservableObject
{

    [ObservableProperty]
    private List<FixFileData> searchedFixFile= new TestDbContext().FixFileData.ToList<FixFileData>();

    //[ObservableProperty]
    //private List<FixFileData> selectedFixFile = new();
    [ObservableProperty]
    private string? selectedTestMachingType;

    [ObservableProperty]
    private string? selectedBoardName;

    [ObservableProperty]
    private string? selectedFixWay;

    [ObservableProperty]
    private DateTime selectedStartDate;

    [ObservableProperty]
    private DateTime selectedEndDate;

    [RelayCommand]
    private void AdvancedSearch()
    {
        using TestDbContext db = new TestDbContext();
        {
            IQueryable<FixFileData> SelectedFile = db.FixFileData.Where(item => item.StartFixDate >= SelectedStartDate && item.StartFixDate <= SelectedEndDate);
            if (SelectedTestMachingType != null)
            {
                SelectedFile = SelectedFile.Where(item => item.TestMachingType.Contains(SelectedTestMachingType));
            }
            if(SelectedBoardName != null) 
            {
                SelectedFile = SelectedFile.Where(item => item.BoardName.Contains(SelectedBoardName));
            }
            if (SelectedFixWay != null)
            {
                SelectedFile = SelectedFile.Where(item => item.FixWay.Contains(SelectedFixWay));
            }
            SearchedFixFile = SelectedFile.ToList();
        }

    }


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
