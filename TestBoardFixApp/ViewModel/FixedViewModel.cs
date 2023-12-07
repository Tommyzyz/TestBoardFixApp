
using Microsoft.Maui.Storage;
using System.IO.Compression;

namespace TestBoardFixApp.ViewModel
{
    public partial class FixedViewModel:ObservableObject
    {
        [ObservableProperty]
        private FixedFileData fixedFile = new();

        [ObservableProperty]
        private bool canSave = false;

        [RelayCommand]
        private void SaveFixed()
        {
            //SavedFixFiles.fixedfiles.Add(FixedFile);
            FixedFile = new();
        }

        [RelayCommand]
        private void CanSaveChick()
        {
            FixedFile.RegisteredPerson = "admin";
            if (FixedFile.TestingMethod != null && FixedFile.FixdMethod != null && FixedFile.FixedFile!= null &&
                FixedFile.RegisteredPerson != null)
            {
                if(FixedFile.Other2==null)
                {
                    FixedFile.Other2 = "空";
                }
                CanSave = true;
            }
        }

        [RelayCommand]
        public async void PickAndShow()
        {

            var result = await FilePicker.PickAsync(new PickOptions { FileTypes = FilePickerFileType.Images });
            if (result != null)
            {
                FixedFile.FixedFile = ImageSource.FromFile(result.FullPath);
            }





        }
    }
}
