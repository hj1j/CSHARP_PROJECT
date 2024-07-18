namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM11
{
static void Main1(String []args)
{
    int[,] array = new int [2, 3]; // 1차원배열(가로)을세로로배치
    Console.WriteLine("차원={0}, 길이={1}", array.Rank, array.Length); // 메서드기능
    
    int[,] arr = new int[2, 3] {{1, 2, 3}, {4, 5, 6}}; // 길이명시
    int[,] arr2 = new int[,] {{1, 2, 3}, {4, 5, 6}}; // 길이생략
    int[,] arr3 = {{1, 2, 3}, {4, 5, 6}}; // 기본표현

    for (int i = 0; i < arr3.GetLength(0); ++i) // 이중for문으로값추가
    {
        for(int j=0; j < arr3.GetLength(1); ++j) // getLength함수(행, 열) 길이
        {
            arr3[i, j] = arr3[i, j] + 1;
        }
    }
 
    foreach (int greeting in arr3)
        Console.WriteLine($"2차원배열의값출력: {greeting}");
    }
}