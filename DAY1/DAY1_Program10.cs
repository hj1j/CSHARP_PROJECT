 /*
 namespace Hello_world;
 public class DAY1_PROGRAM10
 {
 static void Main1(String[]args)
    {
    int i= 100000;
    double d= 1.00001;
    double r= 'C';
    float flt= 0.0001f; // 실수f 표기

    Console.WriteLine("변환전{0} 데이터타입{1}.", d, d.GetType()); // 데이터타입은Double
    d= i; // int --> double로(캐스팅결과: 암시적(자동) 변환)
    Console.WriteLine("변환후{0} 데이터타입{1}.", d, d.GetType()); // 데이터타입변화없음


    d= (double) i; // int --> double로(캐스팅결과: 명시적변환)
    Console.WriteLine("변환후{0} 데이터타입{1}.", d, d.GetType()); // 데이터타입은변화없음
    
    i= e; // 에러이유가?
    i= (int)e; // double --> int로명시적변환
    Console.WriteLine("반대로변환{0}", i); // 소수점어디갔니? 데이터손실이발생한다. (큰걸--> 작은걸로)
    
    flt= chr; // 문제없음
    chr= flt; // 역시반대방향은에러다.
    }
}

// 에러의 오류 -파일 데이터 타입 등이 막 자유분방함.
*/