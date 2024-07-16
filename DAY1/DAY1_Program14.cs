namespace Hello_world;
public class DAY1_PROGRAM14{
static void Main1(String []args)
    {
        int a, b;
        Console.Write("if문예제: 첫번째수를입력해주세요:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("if문예제: 두번째수를입력해주세요:");
        b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("입력된두수는{0}, {1}", a, b);
        
        if(a > b) // 참,거짓조건식: 큰수
        {
            Console.WriteLine("첫번째입력한수가큰수입니다.");
        }
        
        else if(a == b) // 참,거짓조건식: 같은수
        {
            Console.WriteLine("같은숫자입니다");
        }
        
        else // 참,거짓조건식: 이외처리
        {
            Console.WriteLine("두번째입력한수가큰수입니다.");
        }
    }
}