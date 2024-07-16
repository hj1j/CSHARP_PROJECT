namespace Hello_world;
 public class DAY1_PROGRAM12
 {
 static void Main1(String []args)
 {
    int x= 10, y = 3; // 한번에나열하여선언
    double x2= 10, y2= 3.14;
    int result1 = x+ y;

    Console.WriteLine("a와b 연산결과(순서대로계산) : 복합{0}", y+ x * y2 / x2); // 연산자우선순위는?
    Console.WriteLine("a와b 연산결과(우선순위변경) : 복합{0}", (y+ x) * (y2 / x2)); // () 괄호로우선순위지정
    Console.WriteLine("a와b 연산결과(컴파운드연산자) : 계산{0}", result1+=2); // result = result + 2와같음, 대입연산자를생략
    Console.WriteLine("a와b 연산결과(증감연산자) : 계산{0}", result1++); // 1을증가, 값전달이후증가
    Console.WriteLine("a와b 연산결과(증감연산자) : 계산{0}", ++result1); // 1을증가, 증가후값전달
    Console.WriteLine("a와b 연산결과(증감연산자) : 계산{0}, 데이터타입{1}", ++y2, y2.GetType()); // 실수증감후, 데이터타입변화없음
    }
}
