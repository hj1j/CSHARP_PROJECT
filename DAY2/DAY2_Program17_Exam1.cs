
using System.Diagnostics;
using System.Formats.Asn1;

namespace DAY2;

public class DAY2_17{
    
    static void Main1(String [] agrs)
    {
        bool size = false;
        bool integer=false;
        int number = 0;

        Console.WriteLine("문자열을 2개 입력해주세요: ");
        string[] In_PW = Console.ReadLine().Split(' ');

        for(int i=0; i<2; i++){
        if(In_PW[i].Length >=4 && In_PW[i].Length <=6){
            Console.WriteLine("{0} 번째 문자의 길이가 정상입니다.",In_PW[i]);
            size = true;

            integer = Int32.TryParse(In_PW[i], out number);
            Console.WriteLine("{0}", integer);
        }

        if(size == true && integer == true){
            Console.WriteLine("문자열의 길이 및 숫자 포함 검사 결과 : True");
        }
        if(size == false && integer == false){
            Console.WriteLine("{문자열의 길이 및 숫자 포함 검사 결과 : false");
        }

        //Int32.TryParse(Console.ReadLine(), out In_PW);
        }
        //string input = Console.ReadLine();
    }
}

    