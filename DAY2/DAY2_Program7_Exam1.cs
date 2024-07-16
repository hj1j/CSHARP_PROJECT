namespace DAY2_7;

public class DAY2_7
{
    static void Main1(string []args)
    {
        //for
        int A, B;
        Console.WriteLine("더하기 출력을 위한 두 수를 연속 입력 받습니다. : ");
        int input = int.Parse(Console.ReadLine());
        A = input;
        //Console.WriteLine("{0}",A);
        int input2 = int.Parse(Console.ReadLine());
        B= input2;
        //Console.WriteLine("{0}",B);

        Console.WriteLine("두 수의 합은 {0}+{1} = {2} 입니다.", A, B, A+B);
        

    }
    
}