namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM9
{
static void Main1(String []args)
{
    int cnt = 0;
    int avg = 0;
    Console.WriteLine("정수배열을생성합니다. 배열크기입력:");
    cnt = int.Parse(Console.ReadLine());
 
    int[] numbers = new int[cnt]; // 입력한크기의배열생성
    
    for(int i=0; i< cnt; i++){
        Console.WriteLine("{0}번째데이터를입력:", i);
        numbers[i] = Convert.ToInt32(Console.ReadLine()); // 배열값초기화
    }

    for(int i=0; i< cnt; i++){
        avg += numbers[i];
        Console.WriteLine("배열의값: {0}", numbers[i]);
    }
        
    Console.WriteLine("숫자의합평균: {0}", avg/cnt);
    }
}