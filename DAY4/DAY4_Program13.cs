namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM13{
    static void Main1(String []args){
        Weapon2 wp = new Knife2(); // 업캐스팅
        wp.Attack(); // 누구의 공격?
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}", (wp).GetType()); // 변환 후 타입 변경됨?
        
        ((Knife2)wp).Attack(); // 다운 캐스팅
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}", ((Knife2)wp).GetType()); // 변환 후 타입 변경됨?
        wp.Attack(new Gun2()); // 업캐스팅, wp = new Gun2(); 와 같음
        // Knife2 kn = new Gun2(); // 동일 수준의 자식끼리 변환 X

        Knife2 kf = new Knife2();
        ((Weapon2)kf).Attack(); // 업캐스팅
        Console.WriteLine("업캐스팅 후 데이터 타입 {0}", ((Weapon2)kf).GetType()); // 변환 후 타입 변경됨?
    }
}
class Weapon2{
    public void Attack(Gun2 gun2){ Console.WriteLine("부모 : 총을 휘둘러 공격합니다."); }
    public void Attack(){ Console.WriteLine("부모 : 기본 공격합니다."); }
}
class Knife2 : Weapon2{
    public void Attack(){ Console.WriteLine("자식1 : 나이프로 공격합니다."); }
}
class Gun2 : Weapon2 {
    public void shoot(){ Console.WriteLine("자식2 : 총으로 쏩니다."); }
}