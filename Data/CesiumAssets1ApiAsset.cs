//namespace SimpleTest.Data.CesiumAssets1; // Razor won't recognize third level namespace
namespace SimpleTest.CesiumAssets1;

public class ApiAssetType
{
    public string Name { get; set; }
    public string Url { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public double Rx { get; set; }
    public double Ry { get; set; }
    public double Rz { get; set; }
    public string Status { get; set; }
}
