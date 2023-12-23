
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;
using System.Data;
using Newtonsoft.Json;

namespace TestBoardFixApp;

public static class CreatexlsServices
{
    /// <summary>
    /// 导出Excel
    /// </summary>
    /// <param name="table"></param>
    /// <param name="file"></param>
    private static void dataTableToCsv(DataTable table, string file)
    {
        string title = "";
        FileStream fs = new FileStream(file, FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(new BufferedStream(fs), System.Text.Encoding.Default);
        for (int i = 0; i < table.Columns.Count; i++)
        {
            title += table.Columns[i].ColumnName + "\t"; //栏位：自动跳到下一单元格
        }
        title = title.Substring(0, title.Length - 1) + "\n";
        sw.Write(title);
        foreach (DataRow row in table.Rows)
        {
            string line = "";
            for (int i = 0; i < table.Columns.Count; i++)
            {
                line += row[i].ToString().Trim() + "\t"; //内容：自动跳到下一单元格
            }
            line = line.Substring(0, line.Length - 1) + "\n";
            sw.Write(line);
        }
        sw.Close();
        fs.Close();
    }

    public static void WriteExcelFile()
    {
        using TestDbContext db = new TestDbContext();
        var table = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(db.FixFileData.ToList()));
        if(table != null)
        {
            dataTableToCsv(table, @"D:\FixData.xls"); //调用函数 
        }
    }
}

