﻿
using Microsoft.Maui.Storage;

namespace TestBoardFixApp.ViewModel;

public partial class FixViewModel:ObservableObject
{
    [ObservableProperty]
    private FixFileData fixFile=new();

    [ObservableProperty]
    private bool canSave=false;

    [RelayCommand]
    private async void CanSaveChick()
    {
        if (FixFile.TestMachingType != null && FixFile.TestMachingNum != null && FixFile.FixWay != null && 
            FixFile.AbnormalFile != null && FixFile.BoardName != null && FixFile.BoardNum != null && 
            FixFile.ProductName != null&&FixFile.Abnormalphenomena!=null&&FixFile.AbnormalString!=null&&
            FixFile.RegisteredPerson!=null)
        {
            CanSave = true;
        }
    }

    [RelayCommand]
    private async void SaveFix()
    {
            SavedFixFiles.fixFiles.Add(FixFile);
            FixFile = new();
    }



    [RelayCommand]
    public async Task PickAndShow()
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions { FileTypes=FilePickerFileType.Images});
            if (result != null)
            {
                  var stream = await result.OpenReadAsync();
                  FixFile.AbnormalFile=ImageSource.FromStream(() => stream);

            }
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);// The user canceled or something went wrong
        }
    }

}

