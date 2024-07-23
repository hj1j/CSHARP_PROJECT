//DAY3_Program9_Exam2.cs를 중첩 클래스로 수정하시오.

namespace C_SHARP_PROJECT;
public class DAY3_Program15_Exam
{

    static void Main(string [] agrs)
    {
        //student std = new student();
        string[] name = new string[3];
        //int[] score = new int[3];
        double[] score = new double[3];
        int menu = 0;
        student_inout inout = new student_inout(ref name);
        student_inout.student_login login = new student_inout.student_login();
        

        int state = 0;
        
        while(true)
        {
            if(state ==0) 
            {
                Console.WriteLine("로그인 필요, 패스워드를 입력하세요. :");
                {
                    string Pass1 = Console.ReadLine();

                    if(Pass1 == login.pass_get)
                    {
                        Console.WriteLine("패스워드 확인");
                        state=1;
                    }
                    else
                    {
                        Console.WriteLine("로그인 실패");
                        break;
                    }
                }
            }


        Console.WriteLine ("메뉴를 선택하세요 : 1. 학생 점수  입력, 2. 학생 점수 출력, 3. 프로그램 종료");
        menu = int.Parse(Console.ReadLine());

        if(menu == 1)
        {
            //inout.input_score(name, score); //입력
            //for(int i = 0; i<3; i++)
            //{
            Console.WriteLine("0 번 학생의 이름은?");
            name[0] = Console.ReadLine();
            Console.WriteLine("0 번 학생의 점수는?");
            score[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("1 번 학생의 이름은?");
            name[1] = Console.ReadLine();
            Console.WriteLine("1 번 학생의 점수는?");
            score[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("2 번 학생의 이름은?");
            name[2] = Console.ReadLine();
            Console.WriteLine("2 번 학생의 점수는?");
            score[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("이름{0}, 점수{1}",name[0], score[0]);
            //}
            Console.WriteLine("학생 정보 입력 완료!");
        }

        if(menu == 2) //학생 점수 출력
        {
            Console.WriteLine("1번째 학생 이름 : {0}, 점수: {1}", name[0], score[0]);
            Console.WriteLine("2번째 학생 이름 : {0}, 점수: {1}", name[1], score[1]);
            Console.WriteLine("3번째 학생 이름 : {0}, 점수: {1}", name[2], score[2]);
            Console.WriteLine("학생 1명의 평균 점수는 {0}",(score[0]+score[1]+score[2])/3);
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

        public student_inout(ref string[] name){
            name[0] = "guest";
            name[1] = "guest";
            name[2] = "guest"; //생성자로 초기값 호출
            Console.WriteLine("생성자 호출"); 
        }

        public class student_login
        {
            private string Pass = "123123";
            public string pass_get
            {
            get{ return Pass;}
            }

        }
    }
}