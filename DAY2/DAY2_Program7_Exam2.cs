using System.Diagnostics.Metrics;

namespace DAY2_7_2;

public class DAY2_7_2
{

    static void Main(string [] args)
    {
        String PW; //패스워드
        String PWD = "123123";
        //int PWF; //패스워드 실패
        int N=0; //시도횟수

        for(int x=1; x<6; x++){
            Console.WriteLine("비밀번호 입력하기 : ");
            PW = Console.ReadLine();

            if(PW.Length > 9){
                N = N+1;
                Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회", N);
            }

            if(PW.Length < 6){
                N = N+1;
                Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회", N);
            }

            if(PW.Length < 10 && PW.Length > 5){
                if(PW==PWD){
                    Console.WriteLine("로그인 성공");
                    break;
                }
                N = N+1;
                Console.WriteLine("패스워드가 틀립니다!");
                Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회", N);
            }

            if(N==5){
                break;
            }
        }
    }
}



/*
    static void Main(string [] args)
    {
        int PW; //패스워드
        //int PWF; //패스워드 실패
        int N=0; //시도횟수

        for(int x=1; x<6; x++){
            Console.WriteLine("비밀번호 입력하기 : ");
            int input = int.Parse(Console.ReadLine());
            PW=input;
            PW = Convert.ToChar(Console.ReadLine());

            if(PW>=10){
                N = N+1;
                Console.WriteLine("비밀번호가 틀립니다!");
                Console.WriteLine("로그인 실패, 5회 제한 : 현재 {0}회", N);
            }

            if(x==5){
                break;
            }
        }
    }
}
*/
