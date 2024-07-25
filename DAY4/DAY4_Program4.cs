using System.Net.Sockets;

namespace C_SHARP_PROJECT;
    public class DAY4_PROGRAM4
    {
        static void Main()
        {
            Address address = new Address("B1-3029", "BBSR", "Odisha"); // 주소 객체
            Employee employee = new Employee(1001, "Ramesh", address); // 고요인 정보 및 주소 객체 전달
            employee.Display(); // 내용 출력
        }
    }
    class Address // 주소 클래스
    {
        public string AddressLine, City, State;
        public Address(string addressLine, string city, string state)
        {
            AddressLine = addressLine;
            City = city;
            State = state;
        }
    }
    class Employee //고용인 클래스
    {
        public Address address; // 고용인은 주소 정보를 가진다. has 관계
        public int Id;
        public string Name;
        public Employee(int id, string name, Address adrs) //생성자
        {
            Id = id;
            Name = name;
            address = adrs;
        }
        public void Display()
        {
            Console.WriteLine($"고용인 Id: {Id}");
            Console.WriteLine($"고용인 이름: {Name}");
            Console.WriteLine($"주소: {address.AddressLine}");
        }
    }
