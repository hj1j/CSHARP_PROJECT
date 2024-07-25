namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM3{
    static void Main1(){
        Cuboid cuboid = new Cuboid(3,5,7); //직육면체
        Console.WriteLine($"직육면체의 부피는 : {cuboid.Volume()}");
        Console.WriteLine($"직육면체의 겉넓이는 : {cuboid.Perimeter()}");
    }
}
class Rectangle //사각형 클래스
{
    public int Length; //길이
    public int Breadth; //너비
    public int Perimeter()  //겉넓이
    {
        return 2 * (Length + Breadth);
    }
}

class Cuboid : Rectangle //직육면체 is a 관계 성립
{
    public int Height;
    public Cuboid(int l, int b, int h)
    {
        Length = l; //길이
        Breadth = b; //너비
        Height = h; //높이
    }
    public int Volume()
    {
        return Length*Breadth*Height; //부피
    }
}