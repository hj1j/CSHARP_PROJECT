using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DAY3_Program4;
public class DAY3_Program4
{

    static void Main1(string [] agrs)
    {
        //student std = new student();
        student_inout1 inout = new student_inout1();
        string[] name = new string[3];
        int[] score = new int[3];
        int menu = 0;

        while(true)
        {
        Console.WriteLine ("메뉴 선택하세요 : 1. 학생 점수  입력, 2. 학생 잠수 후 출력, 3. 프로그램 종료");
        menu = int.Parse(Console.ReadLine());

        if(menu == 1)
        {
            //inout.input_score(name, score); //입력
        }

        if(menu == 2)
        {
            //inout.print_info(name, score); //출력
        }

        if(menu == 3)
        {
            Console.WriteLine ("프로그램을 종료합니다.");
            break;
        }
        Console.WriteLine("{0} 번 학생의 점수는?");
        string input_score = Console.ReadLine();
        Console.WriteLine("학생 정보 입력 완료!");
        }
    }


    private class student_inout1
    {
        public int[] input_score;
        public string[] print_info;

    }
}

/*
Console.WriteLine
        ("메뉴 선택하세요 : 1. 학생 점수  입력, 2. 학생 잠수 후 출력, 3. 프로그램 종료");

        Console.WriteLine("두 번째 학생의 점수는?");
        string input_score = Console.ReadLine();
        Console.WriteLine("학생 정보 입력 완료!");*/