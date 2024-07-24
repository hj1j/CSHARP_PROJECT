namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM18
{
    static void Mainq(string[] args)
    {
        Console.WriteLine("복사생성자가 없는 경우 : 각 인스턴스 입력");
        Persons person1 = new Persons("홍길동", 20); // 첫째의 이름, 나이 초기화
        Persons person2 = new Persons(person1.name, person1.age); //둘째에 첫째 정보 전달
        //셋째, 넷째... 여섯... 일곱... 모두 해야 하나?
        Console.WriteLine(person1.St_Print());
        Console.WriteLine(person2.St_Print());
    }
}

class Persons{
    public string name {get; set;}  //set/get 프로퍼티
    public int age {get; set;}
    public Persons(string name, int age) //기본 생성자 정의
    {
        this.name = name;
        this.age = age;
    }
    public string St_Print() { //출력용 함수
        return "이름: " + this.name + ", 나이: " + this.age;
    }
}