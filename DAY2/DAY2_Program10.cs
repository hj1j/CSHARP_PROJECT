namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM10
{
static void Main1(String []args)
{
    int[] reading = new int[] { 4, 9, 1, 5, 21, 12, 55 };
    Console.WriteLine("차원={0}, 길이={1}", reading.Rank, reading.Length); // 메서드기능

    Array.Clear(reading, 0, 4); // 인덱스0~2번초기화
    for(int i=0; i< reading.Length; i++){
        Console.WriteLine("배열값출력(지운후) : {0}", reading[i]);
    }

    Array.Resize(ref reading, reading.Length + 3);
    Console.WriteLine("길이={0}", reading.Length);
    for(int i=0; i< reading.Length; i++){
        Console.WriteLine("배열값출력(크기조정후) : {0}", reading[i]);
    }
 
    Array.Resize(ref reading, reading.Length-5);
    Array.Sort(reading);
    for(int i=0; i< reading.Length; i++){
        Console.WriteLine("배열값출력(사이즈+ 정렬후) : {0}", reading[i]);
    }
}
}