namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM9
{
    static void Main1(String []args){
        END_PROGRAM SW = new END_PROGRAM(); // 서브 프로그램 : 자식 클래스 인스턴스 생성
        SW.init(); // 재정의 된 init 메소드 호출됨
        SW.start(); // end 프로그램의 시작 메소드 호출
    }
}
public class Start_Program
{
    public virtual void init(){ // 가상 메소드 정의, virtual 안 쓰면 재정의 x
        Console.WriteLine("프로그램의 최상위 1등 클래스입니다.");
    }
    public void start(){ // 부모의 메소드는 자식 메소드에 가려짐
        Console.WriteLine("프로그램을 시작합니다1.");
    }
}
public class END_PROGRAM : Start_Program // : 으로 상속받음을 표기
{
    public override void init(){ // 오버라이딩(재정의)
        Console.WriteLine("프로그램의 최상위 2등 클래스입니다.");
    }
    public new void start(){ // 메소드 정의
        Console.WriteLine("프로그램을 시작합니다2.");
    }
}
