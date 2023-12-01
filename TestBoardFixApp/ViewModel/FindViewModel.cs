
namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel:ObservableObject
{
    [ObservableProperty]
    private List<FixFileData> selectedFixFile;

    [ObservableProperty]
    private string searchString;

    [RelayCommand]
    private void Search()
    {
        foreach(FixFileData data in SavedFixFiles.fixFiles) 
        {
            if (data.ProductName == SearchString || data.TestMachingNum == SearchString || data.TestMachingType == SearchString || data.BoardName == SearchString || data.BoardNum == SearchString)
            SelectedFixFile.Add(data);
        }
    }
}
