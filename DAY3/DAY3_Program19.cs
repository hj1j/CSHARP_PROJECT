namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM19
{
    static void Main1(string[] args)
    {
        Console.WriteLine("복사생성자 사용");
        Person_COPY person1 = new Person_COPY("홍길동", 20); // 첫째의 이름, 나이 초기화
        Person_COPY person2 = new Person_COPY(person1.name, person1.age); // 둘째에 첫째 정보 전달
        Console.WriteLine(person1.St_Print());
        Console.WriteLine(person2.St_Print());
        
        Person_COPY person3 = new Person_COPY(person1); // 새로운 객체 생성
        Person_COPY person4 = new Person_COPY(person1); // 객체를 복사
        Person_COPY person5 = new Person_COPY(person1);
    }
}
class Person_COPY
{
    public string name { get; set; }
    public int age { get; set; }
    public string address { get; set; }
    public string userID { get; set; }
    public string userPassword { get; set; }
    public string phoneNumber { get; set; }
    public string gender { get; set; }
    
    public Person_COPY(string name, int age) // 기본 생성자 정의
    {
        this.name = name;
        this.age = age;
    }
    public Person_COPY(Person_COPY person) // 복사 생성자 정의
    {
        Console.WriteLine("복사생성자 호출");
        this.name = name;
        this.age = age;
    }
    public string St_Print() { // 출력용 함수
        return "이름: " + this.name + ", 나이: " + this.age;
    }
}
