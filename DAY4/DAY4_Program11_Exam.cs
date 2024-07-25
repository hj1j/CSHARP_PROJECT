namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM11_Exam{
    static void Main1(String []args){
        Meta_Human2 meta_Human2 = new Meta_Human2();
        Wonder_woman wonder_Woman = new Wonder_woman();
        meta_Human2.Skill_1();
        meta_Human2.Skill_2();
        wonder_Woman.Skill_1();
        wonder_Woman.Skill_2();
    }
}

public class Meta_Human2
{
    public virtual void Skill_1()
    {
        Console.WriteLine("채찍공격");
    }
    public virtual void Skill_2() 
    {
        Console.WriteLine("방패막기");
    }
}

public class Wonder_woman : Meta_Human2
{
    public override void Skill_1()
    {
        Console.WriteLine("불꽃채찍");
    }
    sealed public override void Skill_2()
    {
        Console.WriteLine("방패비껴내기");
    }
}