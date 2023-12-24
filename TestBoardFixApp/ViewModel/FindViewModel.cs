﻿namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel(TestDbContext db):ObservableObject
{

    [ObservableProperty]
    private List<FixFileData> searchedFixFile= db.FixFileData.ToList<FixFileData>();

    [ObservableProperty]
    private FixFileData selectedFixFile;

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


    [RelayCommand]
    private void Search(string SearchString)
    {
        if(SearchString!=null) 
        {
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

    [RelayCommand]
    private async Task AddFixedFile()
    {
        FixedFileData FixedFile;
        var FixedFiles = db.FixedFileData.Where(e => e.FixFileDataID == SelectedFixFile.ID).ToList();
        if(FixedFiles.Count > 0) 
        {
            FixedFile = FixedFiles[0];
        }
        else
        {
            FixedFile = new();
            FixedFile.FixFileDataID = SelectedFixFile.ID;
        }
        var navigationParameter = new Dictionary<string, object>
            {
                {"FixedFile",FixedFile}
            };
        await Shell.Current.GoToAsync(Routes.FixedPage, navigationParameter);
    }

}
