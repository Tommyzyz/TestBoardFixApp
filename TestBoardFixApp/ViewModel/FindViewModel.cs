﻿namespace TestBoardFixApp.ViewModel;

public partial class FindViewModel(TestDbContext db):ObservableObject
{

    [ObservableProperty]
    private List<FixFileData> searchedFixFile= db.FixFileData.ToList<FixFileData>();

    [ObservableProperty]
    private FixFileData selectedFixFile;

    [ObservableProperty]
    private string? selectedTestMachineType;

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
            if (SelectedTestMachineType != null)
            {
                SelectedFile = SelectedFile.Where(item => item.TestMachineType.Contains(SelectedTestMachineType));
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
            SearchedFixFile = db.FixFileData.Where(item => item.TestMachineType.Contains(SearchString)||
                                                     item.TestMachineNum.Contains(SearchString)||
                                                     item.RegisteredPerson.Contains(SearchString)||
                                                     item.AbnormalBehavior.Contains(SearchString)||
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
        if(SelectedFixFile!=null)
        {
            FixedFileData FixedFile;
            if (SelectedFixFile.IsFixed == true)
            {
                var FixedFiles = db.FixedFileData.Where(e => e.FixFileDataID == SelectedFixFile.ID).ToList();
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
        else
        {
            await Application.Current.MainPage.DisplayAlert("提示", "请先选中一项", "确定");
        }
    }

}
