namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM13
 {
static void Main1(String []args)
{
    string message1 = "문자열초기화"; // 기본문자열
    string message_null= String.Empty; // 빈문자열""과동일(안전한null)
    string message_start= "문자열의시작부터";
    string message_end= "끝까지!";
    
    Console.WriteLine($"문자열\t 값출력1 : {message1}"); // 단순(보간) 출력, 이스케이프(탭)
    Console.WriteLine($"문자열값\'출력2\' : {message_start+ message_end}"); // 문자열결합, 이스케이프(작은따옴표)
    
    int number = 15;
    string message3 = string.Format("숫자--> 문자{0}", number); // 이전방식format 서식지정, 가독성떨어짐
    Console.WriteLine("문자열변환출력3 : {0}", message3);
    string time = String.Format("It is now {0:d} at {0:t}", DateTime.Now); // 현재시각지정
    string price = String.Format("Price is {0:C}", 512123123);
    Console.WriteLine("문자열변환출력4 : {0}", price); // 통화형식
    Console.WriteLine("문자열변환출력4 : {0}", time); // 날짜형식, 시간형식

    Console.WriteLine($"문자열\t 값출력5 : {Math.PI}"); // 단순(보간) 출력, PI 값(DOUBLE형느려질수있음)
    Console.WriteLine($"문자열\t 값출력5 : {Math.PI.ToString()}"); // 단순(보간) 출력, PI 값(미리STRING 처리)
    }
}
