using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.IO.Compression;

namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM2 // 최상위 클래스가 동물 이라고 가정
{
    public string Name {get; set;} // 이름 set/get
    public int Age=20; //나이 set/get
    static void Main1(String []agrs) {
        Bird 새 = new Bird(); //한글 변수도 잘 동작하지만 사용하지는 말자.
        새.Age = 20;
        새.Name = "훔친새";
        새.Fly();
        //Dog 개 = new Dog();
        //개.Age = 20;
        //개.HowOld();

    }
}
public class Dog : DAY4_PROGRAM2
{
    public void HowOld()
    {
        Console.WriteLine("나이: {0}", this.Age); // 부모 클래스의 나이 사용
    }
}

public class Bird : DAY4_PROGRAM2
{
    public void Fly()
    {
        Console.WriteLine("{0}살 입니다.", this.Age);
        Console.WriteLine("{0}가 날고 있어요!",this.Name);
    }
}