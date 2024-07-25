namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM15{
    static void Main(String []args){
        real_son2 son2 = new real_son2(); // 인자 전달 없는 기본 생성자 호출
        real_son2 son3 = new real_son2("홍길동"); // 문자열 인자 받는 생성자 호출
    }
}

public class mother_end2{
    public mother_end2(){
        Console.WriteLine("어머니의 생성자 호출");
    }
    public mother_end2(string name){
        Console.WriteLine("아들의 이름은 {0}", name);
    }
}
public class real_son1 : mother_end2{
    public real_son1(){ Console.WriteLine("아들1의 생성자 호출"); }
    public real_son1(string name){ Console.WriteLine("아들의 이름은 {0}", name); }
}
public class real_son2 : mother_end2{
    public real_son2(){ Console.WriteLine("아들2의 생성자 호출"); }
    public real_son2(string name){ Console.WriteLine("아들의 이름은 {0}", name); }
}