using System.Security.Cryptography;

namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM8_2{
    static void Main1(String []args){
        Super_man super_Man = new Super_man();
        //Meta_Human meta_Human = new Meta_Human();
        
        Console.ReadLine();
    }
}
public class Meta_Human
{
    public string public_name;
    protected string private_name;
    public int age;
    public int power;
    public string skill;

}

public class Super_man : Meta_Human
{
    public Super_man()
    {
        private_name = "클라크 켄트";
        age = 20;
        power = 30;
        skill = "Fly";
        Console.WriteLine("슈퍼맨의 파워: {0}", power);
    }
}