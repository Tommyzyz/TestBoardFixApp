using Microsoft.UI.Xaml.Controls;

namespace TestBoardFixApp.ViewModel;

public partial class FixViewModel(TestDbContext db):ObservableObject
{
    [ObservableProperty]
    private FixFileData fixFile=new();

    [ObservableProperty]
    private ImageSource? image;

    [ObservableProperty]
    private bool canSave=false;

    [RelayCommand]
    private void CanSaveChick()
    {
        FixFile.RegisteredPerson = "admin";
        if (FixFile.TestMachingType != null && FixFile.TestMachingNum != null && FixFile.FixWay != null && 
            FixFile.AbnormalFile != null && FixFile.BoardName != null && FixFile.BoardNum != null && 
            FixFile.ProductName != null&&FixFile.Abnormalphenomena!=null&&FixFile.AbnormalString!=null&&
            FixFile.RegisteredPerson!=null)
        {
            if(FixFile.Other==null)
            {
                FixFile.Other = "无";
            }
            CanSave = true;
        }
    }

    [RelayCommand]
    private async Task SaveFixAsync()
    {
        db.FixFileData.Add(FixFile);
        await db.SaveChangesAsync();

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
                FixFile.AbnormalFile = ImageSource.FromStream(() => result.OpenReadAsync().Result);
                Image = FixFile.AbnormalFile;
            }
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);// The user canceled or something went wrong
        }
    }

}

