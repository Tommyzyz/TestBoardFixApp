namespace TestBoardFixEFCoreLib;

public class FixFileData
{
    public bool IsFixed { get; set; }


    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
    public long ID { get; set; }

    public string TestMachineType { get; set; } = null!;

    public string TestMachineNum { get; set; } = null!;

    public string BoardName { get; set; } = null!;

    public string BoardNum { get; set; } = null!;

    public string AbnormalBehavior { get; set; } = null!;

    [NotMapped]
    public ImageSource AbnormalFile { get; set; } = null!;

    public string AbnormalString { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string FixWay { get; set; } = null!;

    public string RegisteredPerson { get; set; } = null!;

    [DataType(DataType.DateTime)]
    public DateTime StartFixDate { get; set; }

    public string? Other { get; set; }

    public FixedFileData? FixedFileData { get; set; }

}

public class FixedFileData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
    public long ID { get; set; }

    public string RegisteredPerson { get; set; } = null!;

    public string TestingMethod { get; set; } = null!;

    public string FixedMethod { get; set; } = null!;

    [NotMapped]
    public ImageSource FixedFile { get; set; } = null!;


    [DataType(DataType.DateTime)]
    public DateTime EndFixDate { get; set; }

    public string? Other2 { get; set; }

    public FixFileData FixFileData { get; set; }

    public long FixFileDataID { get; set; }
}

public static class EquipmentData
{
    public static List<string> AbnormalBehaviorData = new() { "Cal_Fail", "Check_Fail", "测试故障" };
    public static List<string> TestMachineTypeData = new() { "3360P", "3380P", "STS8200", "STS8280" };
    public static List<string> BoardNameData = new() { "LPC", "STPMU" };
    public static List<string> FixWayData = new() { "外协维修", "自主维修" };
}






