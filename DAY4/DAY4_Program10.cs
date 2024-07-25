namespace C_SHARP_PROJECT;
class DAY4_PROGRAM10 : Mother{ // 메인 클래스가 직접 상속받음
    //protected override void F() { Console.WriteLine("재정의 된 아들 재산1"); } // 재정의 에러 CS0239
    protected override void F2() { Console.WriteLine("재정의 된 아들 재산2"); }
    static void Main1(String []args){
        DAY4_PROGRAM10 so = new DAY4_PROGRAM10();
        so.F(); // 할머니1, 엄마1 둘중? 확인해보자.
        so.F2(); // 현재 아들의 재산2
        so.get_info1(); // 아들이 물려받은 메소드를 통해 엄마의 상위 메소드 호출
        so.get_info2(); // 현재 자기 자신(아들)의 상위 메소드 호출
    }
    public void get_info2(){
        base.F2(); // 엄마의 부모(할머니) F2 호출
    }
}
class GrandMother{
    protected virtual void F() { Console.WriteLine("원본 할머니 재산1"); }
    protected virtual void F2() { Console.WriteLine("원본 할머니 재산2"); }
    }

class Mother : GrandMother{
    sealed protected override void F() { Console.WriteLine("엄마 재산1 제한됨"); } // sealed로 메소드 제한
    protected override void F2() { Console.WriteLine("재정의된 엄마 재산2"); } // 정상 재정의
    public void get_info1(){
        base.F2(); // 엄마의 부모(할머니) F2 호출
    }
}