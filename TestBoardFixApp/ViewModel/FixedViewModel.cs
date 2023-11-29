
using Microsoft.Maui.Storage;
using System.IO.Compression;

namespace TestBoardFixApp.ViewModel
{
    public partial class FixedViewModel:ObservableObject
    {
        [ObservableProperty]
        private FixedFileData fixedFile = new();



        [RelayCommand]
        private void SaveFixed()
        {
            SavedFixFiles.fixedfiles.Add(FixedFile);
            FixedFile = new();
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
