namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM2
{
static void Main1(String []args)
    {
        Console.WriteLine("do-while문을 테스트합니다. 수 한개를 입력하세요: ");
        int input = int.Parse(Console.ReadLine()); // 11을입력해보자.
        do{
            Console.WriteLine("반복{0}", input); // input 부터10일때까지반복
            input++; // 증감연산자
        } while(input < 10);
        
        Console.WriteLine("do-while문을 다시 테스트합니다. 수 한개를 입력하세요: ");
        input = int.Parse(Console.ReadLine());
        do{
            input--; // 증감연산자
            if(input%2==0){ // 2로나눠지는짝수이면
                continue; // continue 문으로해당루프pass 가능
            }
            if(input < 0){ // 끝나는조건
                break;
            }
            Console.WriteLine("반복{0}", input); // input 부터0일때까지반복
        } while(input < 10);
    }
}