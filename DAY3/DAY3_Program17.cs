namespace C_SHARP_PROJECT;
public class DAY3_Program17
{
    static void object_para_send(Sub_Program2 obj)
    {
        Console.WriteLine("전달받은 객체 {0}", obj);
        Console.WriteLine("변경 여부 : {0}", obj.st_setget);
        obj.st_setget = "함수 객체 전달 완료";
    }
    static void Main1(string[] args)
    {
        Sub_Program2 main = new Sub_Program2(); //인스턴스 객체 생성
        Sub_Program2 main2 = main.Copy();
        main.st_setget = "1번째 객체의 값 설정됨"; //객체 set
        main2.st_setget = "2번째 객체의 값 설정됨"; //객체 set
        object_para_send(main);  // 함수로 main 객체 전달
        object_para_send(main2); // 함수로 main2 객체 전달
    }
}

public class Sub_Program2
{
    public Sub_Program2(){
        st_setget = "default"; // 생성자에서 초기화 필요
    }
    public Sub_Program2 Copy() // 복사 메소드 정의
        {
            return (Sub_Program2)this.MemberwiseClone(); // 복사를 위한 클론 메서드
        }
    public string st_setget {get; set;}  //set/get 프로퍼티

}