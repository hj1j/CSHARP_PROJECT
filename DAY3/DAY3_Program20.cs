namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM20
{
    static void Main1(string[] args)
    {
        Console.WriteLine("객체 인스턴스 비교하기");
        Comparison obj1 = new Comparison("admin"); //인스턴스 객체 생성
        Comparison obj2 = obj1; //객체 2에 객체 1 할당
        Comparison obj_null = null;

        if(Object.ReferenceEquals(obj1, obj2))//인스턴스 비교
        {
            Console.WriteLine("obj1과 obj2는 동일합니다.");
        } else
        {
            Console.WriteLine("obj1과 obj2는 동일하지 않습니다.");
        }
    }
}

class Comparison
{
    public string id {get; set;} // set/get 프로퍼티
    public Comparison(string id) // 기본 생성자 정의
    {
        this.id = id;
    }
}