/*
namespace Hello_world;
public class DAY1_PROGRAM9
{
static void Main1(String []args)
{
    string St_age;
    int In_age;
    int sum;

    Console.WriteLine("당신의나이를입력합니다: ");
    //St_age = Console.ReadLine(); // convert 하지않아도기본문자열
    //sum = St_age + 1; // 왜에러날까? CS0029..잘못받았다.
    
    In_age = Convert.ToInt32(Console.ReadLine()); // 정수로입력
    sum = In_age + 1; // 문제해결!
    Console.WriteLine($"첫번째나이는1살더해서{sum} 살입니다. ");
    Console.WriteLine("결과데이터타입: " + sum.GetType());
    
    Console.WriteLine("당신의나이를다시입력합니다: ");
    In_age = int.Parse(Console.ReadLine()); // 정수입력, Convert.ToInt32과동일
    sum = In_age + 1;
    Console.WriteLine($"두번째나이는1살더해서{sum} 살입니다. ");
    Console.WriteLine("결과데이터타입: " + sum.ToString().GetType());
    
    Console.WriteLine("당신의나이를다시입력합니다: ");
    Int32.TryParse(Console.ReadLine(), out In_age); // 정수입력, 동일but 참/거짓리턴    
    sum = In_age + 1;
    Console.WriteLine($"세번째나이는1살더해서{sum} 살입니다. ");
    Console.WriteLine("결과데이터타입: " + sum.GetType());
    }
}
*/