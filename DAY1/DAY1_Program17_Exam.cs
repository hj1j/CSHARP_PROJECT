namespace DAY1;
public class DAY1_PROGRAM17
{
static void Main1(String []args)
    {
    Console.WriteLine("현재 시간을 입력해 주세요 :");
    int H1 = Convert.ToInt32(Console.ReadLine()); // 문자1개를입력받음
    //switch(grade)1
    //int. parse
    //변수 3개를 입력받는다. int.Parse() 함수 사용 > 나중에 수정.

    Console.WriteLine("현재 시간(분)을 입력해 주세요 :");
    int M1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("현재 시간은 {0}시 {1}분 입니다.", H1, M1);

    Console.WriteLine("요리할 시간(분) 입력해주세요 :");
    int M2 = Convert.ToInt32(Console.ReadLine());
    
    if(M2 == 60) // 참,거짓조건식: 큰수
    {
        H1 = H1+1; M1 = M1+M2-60; 
    }
    else if(M2+M1<60)
    {
        M1=M1+M2;
    }
    else if(H1>=24){
        H1=H1-24;
    }

    Console.WriteLine("요리가 완료될 예상 시간은 {0} 시 {1} 분 입니다.", H1, M1);

    }
}