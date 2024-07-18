using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DAY2;

public class DAY2
{
    static void Main1(String [] args)
    {
   
        
        int[] arr = new int [10] {4, 6, 11, 55, 34, 9, 12, 2, 1, 32};
        
        int max = arr.Max(); int min = arr.Min();
        int sum = arr.Sum();
        Console.WriteLine("차원 = {0}, 길이 ={1}", arr.Rank, arr.Length);

        Console.WriteLine("현재 배열의 최소 값: {0} 최대 값: {1}", min, max);
    
        Console.WriteLine("먹고 남은 빵의 전체 개수는 {0}개", sum-max-min);

        //int[,] arr
    }
}