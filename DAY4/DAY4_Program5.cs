namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM5{
    static void Main1(){
        private_class private_cl = new private_class(); // private지만 클래스 객체 생성 가능
        private_cl.public_method1(); // public 변수, 메소드만 호출 가능
        public_class public_cl = new public_class(); // public 클래스 객체 생성
        public_cl.name = "더 행복해요"; // public 변수, 메소드만 호출 가능
    }
}
class private_class{ // 클래스 default는 internal 이다.
    int a = 12; // 클래스 내부에서 default는 private이다.
    private String name = "아저씨"; // private 변수는 같은 클래스 내에서만
    private void private_method1(){
    }
    public void public_method1(){ // public 변수는 외부에 모두 공개
    }
}

public class public_class{
    internal int b = 15; // 같은 물리적 파일 안에서 접근 가능
    public String name = "행복해요";
    private void private_method2(){
    }
}