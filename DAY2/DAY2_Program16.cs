namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM16
{
static void Main1(String []args)
{
    string message1, message3; // 문자열할당선언
    message1 = message3 = "오늘은 정말 배아파요!"; // 문자열연속초기화
    string message2 = "오늘은 정말 배가 불러요?"; // 다른문자열
    string message4 = "HELLO_WORLD!";
    string message5 = "hello_world!";
    Console.WriteLine($"문자열비교1 : {string.Equals(message1, message3)}"); // 같은문자열true
    Console.WriteLine($"문자열비교2 : {(message1 == message3)}"); // 같은문자열true
    Console.WriteLine($"문자열비교3 : {string.Compare(message1, message3)}"); // 같은문자열0
    Console.WriteLine($"문자열비교4 : {string.Compare(message1, message2)}"); // 다른문자열1
    Console.WriteLine($"문자열비교5 : {(message4 == message5)}"); // 다른문자열?
    Console.WriteLine($"문자열비교6 : {(message4.Equals(message5, StringComparison.OrdinalIgnoreCase))}"); // 대소문자무시비교
    
    string message_null1 = "";
    string message_null2 = " ";
    string message_null3 = "\n";
    Console.WriteLine($"문자열널확인1 : {String.IsNullOrEmpty(message_null1)}"); // 공백이면true
    Console.WriteLine($"문자열널확인2 : {String.IsNullOrEmpty(message_null2)}"); // 공백1개이상이면?
    Console.WriteLine($"문자열널확인3 : {String.IsNullOrWhiteSpace(message_null2)}"); // 공백도널처리
    Console.WriteLine($"문자열널확인4 : {String.IsNullOrEmpty(message_null3)}"); // 개행은?
    }
}