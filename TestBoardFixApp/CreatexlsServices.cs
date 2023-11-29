
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;

namespace TestBoardFixApp;

public static class CreatexlsServices
{
    public static async void createExcel()
    {
        using (ExcelEngine excelEngine = new ExcelEngine())
        {
            Syncfusion.XlsIO.IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;

            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];
            int i = 1;
            // 添加文本、图片、样式等到工作表中
            if(SavedFixFiles.fixFiles.Count > 0)
            foreach(FixFileData Data in SavedFixFiles.fixFiles)
            {
                worksheet.SetText(i, 1, Data.TestMachingType);
                worksheet.SetText(i, 2, Data.TestMachingNum);
                worksheet.SetText(i, 3, Data.BoardName);
                worksheet.SetText(i, 4, Data.BoardNum);
                worksheet.SetText(i, 5, Data.AbnormalFile.ToString());
                worksheet.SetText(i, 6, Data.Abnormalphenomena);
                worksheet.SetText(i, 7, Data.AbnormalString);
                worksheet.SetText(i, 8, Data.FixWay);
                worksheet.SetBoolean(i, 9, Data.IsFixed);
                worksheet.SetText(i, 10, Data.ProductName);
                worksheet.SetText(i, 11, Data.RegisteredPerson);
                worksheet.SetText(i, 12, Data.StartFixDate.ToString());
                worksheet.SetNumber(i, 13,Data.ID);
                i++;
            }
            i = 1;
            if(SavedFixFiles.fixedfiles.Count > 0)
            foreach (FixedFileData Data in SavedFixFiles.fixedfiles)
            {
                worksheet.SetText(i, 17, Data.RegisteredPerson);
                worksheet.SetText(i, 18, Data.FixedFile.ToString());
                worksheet.SetText(i, 19, Data.FixdMethod);
                worksheet.SetText(i, 20, Data.EndFixDate.ToString());
                worksheet.SetText(i, 21, Data.TestingMethod);
                worksheet.SetText(i, 22, Data.ID.ToString());
                worksheet.SetText(i, 23, Data.Other2);
                i++;
            }
            // 保存 Excel 文件
            var fileSaverResult = await FileSaver.Default.SaveAsync("invoice.xlsx", (Stream)workbook, CancellationToken.None);
            if (fileSaverResult.IsSuccessful)
            {
                await Toast.Make($"The file was saved successfully to location: {fileSaverResult.FilePath}").Show(CancellationToken.None);
            }
            else
            {
                await Toast.Make($"The file was not saved successfully with error: {fileSaverResult.Exception.Message}").Show(CancellationToken.None);
            }
        }
    }
}

