namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM6{
    static void Main1(String []args){
        SUB_PROGRAM2 SW = new SUB_PROGRAM2(); // 서브 프로그램 : 자식 클래스 인스턴스 생성
        // SW.init(); 상속이 없는 클래스는 proteced 접근 불가
    }
}
public class Main_Program2{
    protected int protected_check1 = 15; // protected로 선언
    protected static int protected_check2 = 15; // static 추가
    protected void init(){ // 메소드 정의
    Console.WriteLine("프로그램의 최상위 클래스입니다.");
    }
}
public class SUB_PROGRAM2 : Main_Program2{ // : 으로 상속받음을 표기
    DAY4_PROGRAM6 test = new DAY4_PROGRAM6();
    // test.protected_check1 = 15; 자식안에서 부모 객체를 생성해도 접근 불가
    int temp = protected_check2 = 55; // 부모의 protected 사용 가능(메소드 밖은 static만)
    public void start(){ // 메소드 정의
        int temp = base.protected_check1 + 1; // 부모의 protected 사용 가능(메소드 안에서만)
        init(); // 부모의 protected 메소드 호출 가능
        Console.WriteLine("프로그램을 시작합니다.");
    }
    // ** stop(), attack() 생략 **/
}