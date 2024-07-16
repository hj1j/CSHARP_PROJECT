namespace Hello_world;
public class DAY1_PROGRAM8
{
static void Main1(String []args)
{
    Console.WriteLine("Enter your age:");
    int age = Console.Read(); // age에무엇이들어갈지?, 처음에실수많이함
    Console.WriteLine("Your age is: " + age); // 출력결과는? 문자1의ASCII는?
    Console.WriteLine("Enter your birth:");
    var Birth = Convert.ToInt32(Console.ReadLine()); // 정수타입변환
    Console.WriteLine("Your birth is: " + Birth);

    Console.WriteLine("아무키나한번입력해줍니다"); // 중간체크-잠시정지
    Console.ReadKey();
    
    Console.WriteLine("Enter your name:");
    var Name = Convert.ToString(Console.ReadLine()); // 문자열타입변환
    Console.WriteLine("Your Name is: " + Name);
    }
}