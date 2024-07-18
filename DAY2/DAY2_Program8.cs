namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM8
{
static void Main1(String []args)
{
    int[] number1 = {1, 2, 3, 5, 10, 15, 20}; // 배열선언(기본: 타입[] 대괄호)
    int[] number_size= new int[5]{1, 2, 4, 6, 8}; // 크기지정, new 키워드포함
    int[] number2 = new int[]{6, 8}; // 크기지정없이
    number_size[1] = 100; // 배열값수정(인덱스번호)
    number_size[0] += 100; // 배열값단순연산가능
    string[] weekDays= new string[] { "Sun", "Mon", "Tue"}; // 문자열배열

    int count = 1;
    for(int i=0; i < number_size.Length; i++){ // length 크기만큼반복
        Console.WriteLine("배열출력을테스트: {0}", number_size[i]);
        Console.WriteLine("배열출력을테스트(역) : {0}", number_size[^count]); // ^는-1 위치, 역방향
        count++;
    }
 
    foreach(var number_string in number1){ // foreach, var 변수타입
        Console.WriteLine("배열출력을테스트(for-each) : {0}", number_string); // 처음부터끝까지출력
        // Console.WriteLine("배열출력을테스트(for-each) : {0}", weekDays[number_string]);
        }
    }
}