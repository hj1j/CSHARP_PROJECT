namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM14{
    static void Main1(String []args){
        mother mo = new son1();
        bool isson = (mo is son2); // 엄마가 아들2를 참조하는가? is는 bool 반환
    
        if(isson){
            Console.WriteLine("업 캐스팅");
        }
        else{
            Console.WriteLine("캐스팅 불가");
        }
    
        son1 so = (mo as son1); // 엄마가 아들1으로 형변환이 가능한가? as는 참(객체), 거짓(null)
        if(so != null){
            mo = (son1)so;
            Console.WriteLine("다운 캐스팅");
        }
    }
}

public class mother{}
public class son1 : mother{}
public class son2 : mother{}