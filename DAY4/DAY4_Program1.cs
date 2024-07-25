namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM1
{
    static void Main1(String []agrs){
        SUB_PROGRAM SW = new SUB_PROGRAM(); //서브 프로그램: 자식 클래스 인스턴스 생성
        SW.init(); // 메인 프로그램의 초기화 메소드 사용
        SW.start(); // 서브 프로그램의 시작 메소드 사용
        //SW.stop();
        //SW.attack();
    }
}

public class Main_Program
{
    public void init(){ //메소드 정의
        Console.WriteLine("프로그램의 최상위 클래스입니다.");
    }
}

public class SUB_PROGRAM : Main_Program  // : 으로 상속받음을 표기
{
    public void start() { //메소드 정의
        Console.WriteLine("프로그램을 시작합니다.");
    }
    public void stop(){
        Console.WriteLine("잠시 정지합니다.");
    }
    public void attack(){
        Console.WriteLine("친구를 공격합니다.");
    }
}
