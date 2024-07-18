namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM15
{
static void Main1(String []args)
{
    string message1 = "오늘은 정말 '배고픈' 날입니다! HELLO"; // 기본문자열
    int message_index= message1.IndexOf("HE"); // 문자및문자열인덱스확인
    Console.WriteLine($"문자열위치(인덱스) : {message_index}");
    Console.WriteLine($"문자열자르기1 : {message1.Substring(message_index, 5)}"); // 문자열자르기
    Console.WriteLine($"특정문자변경: {message1.Replace('L','l')}"); // 대문자L --> l

    string[] message2 = message1.Split('\'',' '); // ' 따옴표와공백기준자르기
    foreach(var word in message2){ // 분리된문자열반복
    Console.WriteLine($"문자열자르기2 : {word}");
    }
 
    string message3 = "HELLO WORLD!";
    string reversed = new string(message3.Reverse().ToArray()); // for문이아닌reverse 함수, 새배열로복사
    Console.WriteLine($"문자열뒤집기: {reversed}");
    }
}