using System.Diagnostics;

namespace C_SHARP_PROJECT;

public class DAY3_PROGRAM21
{
    static void Main1(string []agrs)
    {
        Sample x = new Sample();
        x.value = "Some Value:";
        Console.WriteLine("객체 삭제 전 값 : {0}", x.value);
        x = null;   //x.value = "Some Value";와는 차이가 있음.
        Console.WriteLine("객체 삭제 후 - null 대입 {0}", x.value);
        x.value = "Some Value";
        GC.Collect();
        Console.WriteLine("객체 삭제 후 - GC 적용 {0}", x.value);
    }
}
public class Sample
{
    public string value{ get; set; }
}