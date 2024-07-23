using System.ComponentModel;
using System.Dynamic;

namespace DAY3_Program4;
public class DAY3_Program9
{

    static void Main1(string [] agrs)
    {
        //student std = new student();
        string[] name = new string[3];
        int[] score = new int[3];
        int menu = 0;
        student_inout inout = new student_inout(ref name);
        
        while(true)
        {
        Console.WriteLine("로그인 필요, 패스워드를 입력하세요. :");
        string Pass1 = Console.ReadLine();
        //Console.WriteLine("{0} 입력", Pass1);

        if(Pass1 == inout.get())
        {
            Console.WriteLine("패스워드 확인");
        }


        Console.WriteLine ("메뉴 선택하세요 : 1. 학생 점수  입력, 2. 학생 점수 출력, 3. 프로그램 종료");
        menu = int.Parse(Console.ReadLine());

        if(menu == 1)
        {
            //inout.input_score(name, score); //입력
             Console.WriteLine("{0} 번 학생의 점수는?");
            string input_score = Console.ReadLine();
            Console.WriteLine("학생 정보 입력 완료!");
        }

        if(menu == 2) //학생 점수 출력
        {
            Console.WriteLine("1번째 학생 이름 : {0}", name[0]);
            Console.WriteLine("2번째 학생 이름 : {0}", name[1]);
            Console.WriteLine("3번째 학생 이름 : {0}", name[2]);
            //inout.print_info(name, score); //출력
        }

        if(menu == 3)
        {
            Console.WriteLine ("프로그램을 종료합니다.");
            break;
        }
       
        }
    }


    private class student_inout
    {
        public int[] input_score;
        public string[] print_info;

        private string Pass = "123123";

        public student_inout(ref string[] name){
            name[0] = "guest";
            name[1] = "guest";
            name[2] = "guest"; //생성자로 초기값 호출
            Console.WriteLine("생성자 호출"); 
        }

        public string get(){
            return Pass;
        }

    }
}