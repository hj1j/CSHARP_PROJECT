using System.Dynamic;

namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM22_Exam
{
    public string Object_init {get; set;}
    
    static void Main(string []agrs)
    {
        Calculator calculator = new Calculator();
        Object_init objectInit = new Object_init(calculator);
        //Object_init objectInit = new Object_init(calculator);
    }
}


    public class Calculator
    {
    int input_x;
    int input_y;

        public Calculator()
        {
            Calculator_start_menu();
        }
        // public Calculator(Object_init objectInit)
        // {
        //     Calculator_start_menu();
        // }
        
        public void Calculator_start_menu()
        {
            while(true){       //반복 시작

                Console.WriteLine("계산기 s/w를 시작합니다. (초기화 완료)");
                Console.WriteLine("계산기 : 1. 숫자 입력, 2. 더하기, 3. 빼기, 4. 곱셈, 5. 프로그램 종료");
                int cal = int.Parse(Console.ReadLine());
                
                if(cal==1) //1번
                {
                    Console.WriteLine("1. 숫자 입력");
                    Calculator_input_value(); //입력받음
                    //Calculator_print_value(); //출력
                }
                if(cal==2)
                {
                    Console.WriteLine("2.더하기");
                    Calculator_print_value1(); //출력1
                }
                if(cal==3)
                {
                    Console.WriteLine("3.빼기");
                    Calculator_print_value2(); //출력2
                }
                if(cal==4)
                {
                    Console.WriteLine("4.곱하기");
                    Calculator_print_value3(); //출력3
                }
                if(cal==5)
                {
                    Console.WriteLine("5.종료"); //프로그램 종료
                break;
            }
            }
        }
        
            
        public void Calculator_input_value()
        {
            Console.Write("첫 번째 숫자를 입력하세요: ");
            input_x = int.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            input_y = int.Parse(Console.ReadLine());
        }
        
        public void Calculator_print_value1() //더하기
        {
            Console.WriteLine("계산 결과를 출력합니다:");
            Console.WriteLine("입력받은 인자값을 더한 결과: {0}", input_x + input_y );
        }
        public void Calculator_print_value2() //빼기
        {
            Console.WriteLine("계산 결과를 출력합니다:");
            Console.WriteLine("입력받은 인자값을 뺀 결과: {0}", input_x - input_y );
        }
        public void Calculator_print_value3() //곱하기
        {
            Console.WriteLine("계산 결과를 출력합니다:");
            Console.WriteLine("입력받은 인자값을 곱한 결과: {0}", input_x * input_y );
        }

    }

public class Object_init
{
    public Object_init(Calculator calculator)
        {
            calculator.Calculator_start_menu();
        }

}


// public class Object_init
// {
//     public Object_init(Calculator calculator)
//         {
//         }

// }