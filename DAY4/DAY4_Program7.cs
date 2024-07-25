public class DAY4_PROGRAM7
{
    static void Main1(String []args){
        SUB_PROGRAM SW = new SUB_PROGRAM(); // 서브 프로그램 : 자식 클래스 인스턴스 생성
        // SW.init(); // 메인 프로그램의 초기화 메소드 호출 불가
        SW.start(); // 서브 프로그램의 시작 메소드 사용
    }
}
sealed class Main_Program // sealed로 상속 제한
{
    public void init(){ // 메소드 정의
        Console.WriteLine("프로그램의 최상위 클래스입니다.");
    }
}
public class SUB_PROGRAM // : Main_Program // : 상속이 안된다.
{
    public void start(){ // 메소드 정의
        Console.WriteLine("프로그램을 시작합니다.");
    }
}