using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace C_SHARP_PROJECT;
public class Challenge_EXAM4
{
    int cnt;
    int user_number = 0;
    int computer_number = 0;
    int menu1;
    int menu2;
    int sum1 = 0;
    int sum2 = 0;
    bool stop = true;
public void Menu_Print()
{
while(stop)
{
    Console.WriteLine("카드 게임을 시작합니다 : 1.게임 시작, 2. 게임 종료");
    menu1= int.Parse(Console.ReadLine());
    if(menu1==1)
    {
    Console.WriteLine("1. 카드 뽑기(3번까지 수행), 2. 카드 자동 뽑기 3. 메뉴로 돌아가기");
    menu2 = int.Parse(Console.ReadLine());
        if(menu2==1)
        {
            Card_Open();
            Console.WriteLine("1. 카드 뽑기(3번까지 수행), 2. 메뉴로 돌아가기");
            menu2 = int.Parse(Console.ReadLine());
            if(menu2==2)
            {
                Console.WriteLine("메뉴로 이동");
                continue;
            }
                if(menu2==1)
                {
                Card_Open();
                Console.WriteLine("1. 카드 뽑기(3번까지 수행), 2. 메뉴로 돌아가기");
                menu2 = int.Parse(Console.ReadLine());
                if(menu2==2)
                {
                    Console.WriteLine("메뉴로 이동");
                    continue;
                }
                    if(menu2==1)
                    {
                    Card_Open();
                    Console.WriteLine("카드 게임의 결과 : ");
                    if(sum2>sum1)
                    {
                    Console.WriteLine("컴퓨터가 승리했습니다.");
                    break;
                    }
                    if(sum2<sum1)
                    {
                    Console.WriteLine("유저가 승리했습니다.");
                    break;
                    }
                    }
                    if(menu2==2)
                    {
                       Console.WriteLine("메뉴로 이동");
                        continue;
                    }

                }
        }
        else if(menu2==2)
        {
            for(int i=0; i<100; i++)
            {
                Card_Auto_Open();
            }
            Console.WriteLine("가장 많이 승리한 사람은");
            break;
        }
        else if(menu2==3)
        {
            Console.WriteLine("메뉴로 돌아가기");
        }
        
        else
        {
            Console.WriteLine("다시 입력");
            menu2 = int.Parse(Console.ReadLine());
        }    
    }
    if(menu1==2)
    {
        Console.WriteLine("게임 종료");
        stop = false;
    } 
}

     
}


    public void Card_Open()
    {
        Random random = new Random();
        int r = random.Next(1,100);
        int r2 = random.Next(1,100);
        Console.WriteLine("{0}번째 사용자 카드 뽑기 결과: {1}", user_number, r);
        sum1 = sum1+r; //유저의 수
        Console.WriteLine("{0}번째 컴퓨터 카드 뽑기 결과: {1}", computer_number, r2);
        sum2 = sum2+r2; //컴퓨터의 수
        Console.WriteLine("현재 유저의 수의 합: {0}", sum1);
        Console.WriteLine("현재 컴퓨터의 수의 합: {0}", sum2);
        user_number++;
        computer_number++;
    }

    public void Card_Auto_Open()//자동으로 100번 진행
    {
        Random random = new Random();
        int r_1 = random.Next(1,100);
        int r_2 = random.Next(1,100);
        int r_3 = random.Next(1,100);
        GAME game = new GAME();
        CARD card = new CARD();
        string u1 = "user1";
        string u2 = "user2";
        string u3 = "user3";
        int CARD1 = 0;
        int CARD2 = 0;
        int CARD3 = 0;
        int win1 = 0;
        int win2 = 0;
        int win3 = 0;

        for(int i=0; i<3; i++)
        {
        Console.WriteLine("{0}번째 {1} 카드 뽑기 결과: {2}", i, u1, r_1);
        CARD1=CARD1+r_1;
        Console.WriteLine("{0}번째 {1} 카드 뽑기 결과: {2}", i, u2, r_2);
        CARD2=CARD2+r_2;
        Console.WriteLine("{0}번째 {1} 카드 뽑기 결과: {2}", i, u3, r_3);
        CARD3=CARD3+r_3;
        }
        Console.WriteLine("1: {0}, 2: {1}, 3: {2}", CARD1, CARD2, CARD3);
        if (CARD1>CARD2&&CARD1>CARD3)
        {
        Console.WriteLine("승자: user1");
        }
        if (CARD2>CARD1&&CARD2>CARD3)
        {
        Console.WriteLine("승자: user2");
        }
        if (CARD3>CARD2&&CARD3>CARD1)
        {
        Console.WriteLine("승자: user3");
        }
    }

    static void Main (String [] args)
    {
        Challenge_EXAM4 main = new Challenge_EXAM4();
        main.Menu_Print();
    }
}

public class CARD()
{

}

public class GAME()
{
    
}