namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM12
{
    static void Main1(String []args){
        Weapon w = new Weapon(); // 무기 객체만 생성
        w.Attack();
        Gun g = new Gun(); // 총 객체 생성
        g.Attack(); // 총 객채에서 기본 공격
    }
}
class Weapon{
    public void Attack()  //오버라이딩 없는 메소드 중첩
    {
        Console.WriteLine("기본 공격합니다.");
    }
}
class Knife : Weapon{
    public new void Attack() // 오버라이딩 없는 메소드 중첩
    {
        Console.WriteLine("나이프를 휘두릅니다.");
    }
}
class Gun : Weapon {
    public void shoot(){ Console.WriteLine("총을 쏩니다."); }
}