namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM3
{
static void Main1(String []args)
{
    int input = 0; //메서드 내 전역변수
        
    while(true) // 조건식: true 참을명시
    {
        Console.WriteLine("while문 + switch문을테스트합니다. 메뉴번호를입력해주세요: ");
        Console.WriteLine("1. 출력테스트2. 프로그램종료");
        input = int.Parse(Console.ReadLine()); // 반복문내지역변수로사용, 둘다수행해보자.
    
            switch(input)
            {
                case 1:
                    Console.WriteLine("안녕하세요. 홍길동 님 방갑습니다"); // 단순출력
                    break;
                case 2:
                    Console.WriteLine("프로그램을종료합니다.");
                    break;
                default:
                    Console.WriteLine("잘못입력!!");
                    break;
            }
                
            if(input==2){
                break;
            }
        }
    }
}
