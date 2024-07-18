namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM14
{
static void Main1(String []args)
{
    string message1 = "문자열초기화"; // STRING클래스는불변클래스(변경x)
    string message2 = message1 + " " + "afadddDDD"; // + 연산자로연결
    string code_message = @"
    public string ReadFile(string filename)
    {
        if (!string.IsNullOrEmpty(filename))
        {
            return File.ReadAllText(filename);
}
return string.Empty;
}
";
Console.WriteLine($"문자열\t 값출력1 : {message1}"); // 단순(보간) 출력, 이스케이프(탭)
Console.WriteLine($@"문자열\t 값출력\n 2 : {message1}\t"); // @ 심벌로이스케이프무시
Console.WriteLine($"문자열값출력3 : {code_message}"); // @ 심벌로+ 없이코드입력
Console.WriteLine($"문자열길이: {code_message.Length} 대소문자{message2.ToUpper()}"); // 메서드활용
}
}