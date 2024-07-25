namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM8{
    static void Main1(String []args){
        Human human = new Human();
        Teacher teacher = new Teacher();
        Students students = new Students();
        Workers workers = new Workers();
        teacher.Study();
        {
            
        }
    }
}
public class Human
{
    public string name;
    public int age;
    public int inch;
} 
public class Teacher : Human
{
    string subject;
    public void Study()
    {
        Console.WriteLine("공부를 한다.");
    }
    public void Teach()
    {
        Console.WriteLine("아이들을 가르친다.");
    }
    
}

public class Students : Human
{
    string calssroom;
    public void Study()
    {
        Console.WriteLine("공부를 한다.");
    }
    public void academy()
    {
        Console.WriteLine("학원을 간다.");
    }
    
}

public class Workers : Human
{
    string part;
    public void working()
    {
        Console.WriteLine("일을 한다.");
    }
    public void go_work()
    {
        Console.WriteLine("출근을 한다.");
    }
}
