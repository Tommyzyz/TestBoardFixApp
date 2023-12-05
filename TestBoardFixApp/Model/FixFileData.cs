
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace TestBoardFixApp.Model;

public class FixFileData
{
    public bool IsFixed {  get; set; }


    [Key]
    public Int64 ID { get; set; }

    public string TestMachingType { get; set; }

    public string TestMachingNum { get; set; }

    public string BoardName { get; set; }

    public string BoardNum { get; set; }
    
    public string Abnormalphenomena { get; set; }

    [NotMapped]
    public ImageSource AbnormalFile { get; set; }

    public string AbnormalString { get; set; }

    public string ProductName {  get; set; }

    public string FixWay { get; set; }

    public string RegisteredPerson { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime StartFixDate { get; set; }

    public string? Other {  get; set; }
    
}

public class FixedFileData
{
    public Int64 ID { get; set; }

    public string RegisteredPerson { get; set; }

    public string TestingMethod { get; set; }

    public string FixdMethod { get; set; }

    public ImageSource FixedFile { get; set; }

    public DateTime EndFixDate { get; set; }

    public string? Other2 { get; set; }
}

public static class EquipmentData
{
    public static List<string> AbnormalphenomenaData = new() {"Cal_Fail","Check_Fail","测试故障"};
    public static List<string> TestMachineTypeData = new() { "3360P", "3380P", "STS8200", "STS8280"};
    public static List<string> BoardNameData = new() { "LPC","STPMU"};
    public static List<string> FixWayData = new() { "外协维修", "自主维修" };
}






