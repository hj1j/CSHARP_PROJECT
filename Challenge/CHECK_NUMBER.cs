using System.Globalization;

namespace Challenge;

public class Challenge1
{
    static void Main(String [] agrs)
    {
        Console.WriteLine("주민등록번호를 입력해주세요");
        string Number = Console.ReadLine();  //입력 받기

        if(Number.Length == null ^ Number.Length <= 12 ^ Number.Length >= 15) //입력이 없거나 잘못된 입력이면 다시 입력받는다.
        {
        Console.WriteLine("잘못된 입력입니다.");    
        }

        

            if(Number.Length == 14) //14자리인 경우
            {
            Console.WriteLine("{0}는 열 네 자리", Number);

                if(Number[6]=='-'^Number[6]==' ')
                {
                Console.WriteLine("7번째에 하이픈 또는 공백 있음"); //하이픈 또는 공백 체크
                string Number2 = Number.Replace("-","").Replace(" ","");//중간 문자 처리
                Console.WriteLine("{0}", Number2);
                    //전부 숫자인지 검사
                    for (int i=0; i<1; i++)
                    {
                    int num=0;
                    bool integer = false;
                    integer = int.TryParse(Number2, out num);
                    Console.WriteLine("{0}", integer);
                    if(integer == true)
                    {
                    Console.WriteLine("모두 숫자가 맞습니다.");
                    }
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }    
            }

                //전체가 하이픈인 경우 추가if(Number)

            if(Number.Length == 13) //13자리인 경우
            {
            Console.WriteLine("{0}는 열 세 자리", Number);
            //전부 숫자인지 검사
            for (int i=0; i<1; i++)
            {
            int num1=0;
            bool integer1 = false;
            integer1 = int.TryParse(Number, out num1);
            Console.WriteLine("{0}", integer1);
                if(integer1 == true)
                {
                Console.WriteLine("모두 숫자가 맞습니다.");
                }
                else
                {
                Console.WriteLine("잘못된 입력입니다.");
                }  
            }
            }
              

            else
            {
            Console.WriteLine("다시 입력해주세요.");
            }

    }
}




