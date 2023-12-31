﻿
using Microsoft.Maui.Storage;
using System.IO.Compression;

namespace TestBoardFixApp.ViewModel
{
    [QueryProperty(nameof(FixedFile), "FixedFile")]
    public partial class FixedViewModel(TestDbContext db):ObservableObject
    {
        [ObservableProperty]
        private FixedFileData fixedFile;

        [ObservableProperty]
        private ImageSource? image;


        [ObservableProperty]
        private bool canSave = false;

        [RelayCommand]
        private async Task SaveFixedAsync()
        {
            db.Update(FixedFile);
            await db.SaveChangesAsync();
            await Application.Current.MainPage.DisplayAlert("提示", "保存成功", "确定");
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private void CanSaveChick()
        {
            FixedFile.RegisteredPerson = "admin";
            if (FixedFile.TestingMethod != null && FixedFile.FixedMethod != null && FixedFile.FixedFile != null &&
                FixedFile.RegisteredPerson != null)
            {
                if(FixedFile.Other2 ==null)
                {
                    FixedFile.Other2 = "空";
                }
                CanSave = true;
            }
        }

        [RelayCommand]
        public async Task PickAndShow()
        {
            var result = await FilePicker.PickAsync(new PickOptions { FileTypes = FilePickerFileType.Images });
            if (result != null)
            {
                FixedFile.FixedFile = ImageSource.FromFile(result.FullPath);
                Image = FixedFile.FixedFile;
            }
        }
    }
}
