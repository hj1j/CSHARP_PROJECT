namespace C_SHARP_PROJECT;
class DAY3_Program16
{
    static void object_para_send(Sub_Program1 obj)
    {
        Console.WriteLine("전달받은 객체 {0}", obj);
        Console.WriteLine("변경 여부 : {0}", obj.st_setget);
        obj.st_setget = "함수 객체 전달 완료";
    }
    static void Main1(string[] args)
    {
        Sub_Program1 main = new Sub_Program1(); //인스턴스 객체 생성
        main.st_setget = "객체의 값 설정됨"; //객체 set
        Sub_Program1 main2 = new Sub_Program1();
        main2= main;
        object_para_send(main); //함수로 main 객체 전달
        object_para_send(main2); //함수로 main2 객체 전달
    }
}

public class Sub_Program1
{
    public Sub_Program1(){
        st_setget = "default"; //생성자에서 초기화 필요
    }
    public string st_setget {get; set;} //set/get 프로퍼티
}